using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCapas
{
    public partial class ListarInformes : Form
    {
        public ListarInformes()
        {
            InitializeComponent();
        }

        private void btnInformeOrdenId_Click(object sender, EventArgs e)
        {
            if (txtordenId.Text == "")
                return;
            ReportDataSource ReportDataSourceReporte;
            DataSet ds = new DataSet();
            var DAtmp = new DatosReporteTableAdapters.Orden_x_IDTableAdapter();
            ReportDataSourceReporte = new ReportDataSource();
            var dt = new DatosReporte.Orden_x_IDDataTable();
            DAtmp.Fill(dt, Convert.ToInt32(txtordenId.Text));
            dt.TableName = "dsOrdenesId";
            ds.Tables.Add(dt);
            var frm = new VisorInformes();
            frm.vistaPreliminar(ds, "dsOrdenesId", "AplicacionCapas.rptOrdenesID.rdlc");
            frm.ShowDialog();
            //this.Close(); 
        }

        private void ListarInformes_Load(object sender, EventArgs e)
        {

        }

        private void btnOrdenCliente_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text == "")
                return;
            ReportDataSource ReportDataSourceReporte;
            DataSet ds = new DataSet();
            var DAtmp = new DatosReporteTableAdapters.Orden_x_ClienteTableAdapter();
            ReportDataSourceReporte = new ReportDataSource();
            var dt = new DatosReporte.Orden_x_ClienteDataTable();
            DAtmp.Fill(dt, txtCodigoCliente.Text);
            dt.TableName = "dsOrdenCliente";
            ds.Tables.Add(dt);
            var frm = new VisorInformes();
            frm.vistaPreliminar(ds, "dsOrdenCliente", "AplicacionCapas.rptOrdenCliente.rdlc");
            frm.ShowDialog();
            //this.Close();

        }
    }
}
