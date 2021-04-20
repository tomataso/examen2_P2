

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProgressBarExam.Models.Controls;

 namespace ProgressBarExam.Models.Helpers
{
    public static class ControlExtensions
    {

        public static HtmlString CtrlProgressBar(this HtmlHelper html, string id, string pPorcentaje , string pColor)
        {
            var ctrl = new CtrlProgressBar
            {
                Id = id,
                Porcentaje = pPorcentaje,
                Color = pColor
            }; ;


            return new HtmlString(ctrl.GetHtml());
        }

    }
}