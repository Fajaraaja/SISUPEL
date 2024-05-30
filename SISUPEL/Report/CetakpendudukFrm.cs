using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace SISUPEL.Report
{
    public partial class CetakpendudukFrm : Form
    {

        public string kode = "";

        public CetakpendudukFrm()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void CetakpendudukFrm_Load(object sender, EventArgs e)
        {
            ReportDocument Rep = new ReportDocument();
            Rep.Load(@"D:\Kuliah\PBO 2\SISUPEL2\SISUPEL\Report\PendudukCrp.rpt");
            Rep.SetDatabaseLogon("root", "");

            ParameterFieldDefinitions pars;
            ParameterFieldDefinition par;
            ParameterValues parvalues = new ParameterValues();
            ParameterDiscreteValue pardiscrete = new ParameterDiscreteValue();

            pardiscrete.Value = kode;
            pars = Rep.DataDefinition.ParameterFields;
            par = pars["kodepen"];
            parvalues = par.CurrentValues;
            

            parvalues.Clear();
            parvalues.Add(pardiscrete);
            par.ApplyCurrentValues(parvalues);

            crystalReportViewer1.ReportSource = Rep;
            crystalReportViewer1.Refresh();
        }
    }
}
