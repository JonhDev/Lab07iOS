using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NorthWind;

namespace NorthWindModel
{
    public class NorthWindModelClass: INorthWindModel
    {
		public event ChangeStatusEventHandler ChangeStatus;

		public async Task<IProduct> GetProductByIDAsync(int ID)
		{
			using (HttpClient cliente = new HttpClient())
			{
				cliente.DefaultRequestHeaders.Accept.Clear();
				cliente.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

				ChangeStatus(this, new ChangeStatusEventArgs(StatusOptions.CallingWebAPI));

				HttpResponseMessage respuesta = await cliente.GetAsync($"https://ticapacitacion.com/webapi/northwind/product/{ID}");

				ChangeStatus(this, new ChangeStatusEventArgs(StatusOptions.VerifyingResult));

				if (respuesta.IsSuccessStatusCode)
				{
					string json = await respuesta.Content.ReadAsStringAsync();
					Product producto = JsonConvert.DeserializeObject<Product>(json);
					StatusOptions option;
					if (producto != null)
						option = StatusOptions.ProductFound;
					else
						option = StatusOptions.ProductNotFound;
					ChangeStatus(this, new ChangeStatusEventArgs(option));
					return producto;
				}
				else
				{
					ChangeStatus(this, new ChangeStatusEventArgs(StatusOptions.ProductNotFound));
					return null;
				}

			}
		}
	}

	class ChangeStatusEventArgs : EventArgs, IChangeStatusEventArgs
	{
		public StatusOptions Status { get; set; }

		public ChangeStatusEventArgs(StatusOptions option)
		{
			Status = option;
		}
	}
}
