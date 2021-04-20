using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgressBarExam.Models.Controls
{
    public class CtrlProgressBar : CtrlBaseModel
    {



        public string Id { get; set; }

        // Aca van coordenadas de SJ Costa Rica Quemadas.
        public string Porcentaje { get; set; } = "50%";
        public string Color { get; set; } = "#FF0000";
        // El Color aca hexagecimal es Rojo.
        


        public CtrlProgressBar()
        {
            ViewName = "";
        }





    }
}