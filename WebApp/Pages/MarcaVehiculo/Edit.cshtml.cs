using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApp.Pages.MarcaVehiculo
{
    public class EditModel : PageModel
    {
        private readonly IMarcaVehiculoService marcaVehiculoService;

        public EditModel(IMarcaVehiculoService marcaVehiculoService)
        {
            this.marcaVehiculoService = marcaVehiculoService;
        }

        [BindProperty]
        public MarcaVehiculoEntity Entity { get; set; } = new MarcaVehiculoEntity();

    }
}
