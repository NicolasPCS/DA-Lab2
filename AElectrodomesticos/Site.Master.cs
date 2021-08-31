using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AElectrodomesticos
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                Electrodomesticos.Items.Add(new ListItem("Cocina", "1"));
                Electrodomesticos.Items.Add(new ListItem("Licuadora", "2"));
                Electrodomesticos.Items.Add(new ListItem("Horno Microondas", "3"));
                Electrodomesticos.Items.Add(new ListItem("Refrigerador", "4"));
                Electrodomesticos.Items.Add(new ListItem("Televisor", "5"));
                Electrodomesticos.Items.Add(new ListItem("Aspiradora", "6"));
                Cocina.Visible = false;
                Licuadora.Visible = false;
                Microondas.Visible = false;
                Refrigerador.Visible = false;
                Televisor.Visible = false;
                Aspiradora.Visible = false;
            }
            grafico.Visible = false;
        }

        protected void MostrarServerClick(Object sender, EventArgs e)
        {
            ListItem seleccion = Electrodomesticos.Items[Electrodomesticos.SelectedIndex];
            if (seleccion.Value == "1")
            {
                Resultado.InnerText = "Usted ha seleccionado la cocina y sus características son:";
                Cocina.Visible = true;
                Licuadora.Visible = false;
                Microondas.Visible = false;
                Refrigerador.Visible = false;
                Televisor.Visible = false;
                Aspiradora.Visible = false;

                // Metodo para mostrar imagen
                grafico.Src = "figura" + Electrodomesticos.SelectedIndex.ToString() + ".jpg";
                grafico.Alt = "Cocina";
                grafico.Visible = true;
            }
            if (seleccion.Value == "2")
            {
                Resultado.InnerText = "Usted ha seleccionado la licuadora";
                Cocina.Visible = false;
                Licuadora.Visible = true;
                Microondas.Visible = false;
                Refrigerador.Visible = false;
                Televisor.Visible = false;
                Aspiradora.Visible = false;

                // Metodo para mostrar imagen
                grafico.Src = "figura" + Electrodomesticos.SelectedIndex.ToString() + ".jpg";
                grafico.Alt = "Licuadora";
                grafico.Visible = true;
            }
            if (seleccion.Value == "3")
            {
                Resultado.InnerText = "Usted ha seleccionado el horno microondas";
                Cocina.Visible = false;
                Licuadora.Visible = false;
                Microondas.Visible = true;
                Refrigerador.Visible = false;
                Televisor.Visible = false;
                Aspiradora.Visible = false;

                // Metodo para mostrar imagen
                grafico.Src = "figura" + Electrodomesticos.SelectedIndex.ToString() + ".jpg";
                grafico.Alt = "Microondas";
                grafico.Visible = true;
            }
            if (seleccion.Value == "4")
            {
                Resultado.InnerText = "Usted ha seleccionado el refrigerador";
                Cocina.Visible = false;
                Licuadora.Visible = false;
                Microondas.Visible = false;
                Refrigerador.Visible = true;
                Televisor.Visible = false;
                Aspiradora.Visible = false;

                // Metodo para mostrar imagen
                grafico.Src = "figura" + Electrodomesticos.SelectedIndex.ToString() + ".jpg";
                grafico.Alt = "Refrigerador";
                grafico.Visible = true;
            }
            if (seleccion.Value == "5")
            {
                Resultado.InnerText = "Usted ha seleccionado el televisor";
                Cocina.Visible = false;
                Licuadora.Visible = false;
                Microondas.Visible = false;
                Refrigerador.Visible = false;
                Televisor.Visible = true;
                Aspiradora.Visible = false;

                // Metodo para mostrar imagen
                grafico.Src = "figura" + Electrodomesticos.SelectedIndex.ToString() + ".jpg";
                grafico.Alt = "Televisor";
                grafico.Visible = true;
            }
            if (seleccion.Value == "6")
            {
                Resultado.InnerText = "Usted ha seleccionado la aspiradora";
                Cocina.Visible = false;
                Licuadora.Visible = false;
                Microondas.Visible = false;
                Refrigerador.Visible = false;
                Televisor.Visible = false;
                Aspiradora.Visible = true;

                // Metodo para mostrar imagen
                grafico.Src = "figura" + Electrodomesticos.SelectedIndex.ToString() + ".jpg";
                grafico.Alt = "Aspiradora";
                grafico.Visible = true;
            }
        }
    }
}