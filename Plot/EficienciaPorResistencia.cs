using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CircuitosLab03.Plot
{
    public class EficienciaPorResistencia
    {
        public void Plot(string output)
        {
            double[] resistencia = new double[] { 1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000 };
            double[] eficiencia = new double[] { 16.671, 28.572, 37.504, 44.437, 50, 54.554, 58.331, 61.534, 64.286, 66.672 };

            ScottPlot.Plot plot = new ScottPlot.Plot(800, 600);
            plot.PlotScatter(resistencia, eficiencia, color: Color.Pink, lineWidth: 2);
            plot.XLabel("Resistência");
            plot.YLabel("Eficiência");
            plot.Title("Eficiência x Resistência");
            plot.SaveFig(output);
        }
    }
}
