using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CircuitosLab03.Plot
{
    public class PotenciaPorResistencia
    {
        public void Plot(string output)
        {
            double[] resistencia = new double[] { 1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000 };
            double[] potenciaPotenciometro = new double[] { 2.779, 4.083, 4.688, 4.937, 5, 4.959, 4.859, 4.732, 4.590, 4.447 };

            ScottPlot.Plot plot = new ScottPlot.Plot(800, 600);
            plot.PlotScatter(resistencia, potenciaPotenciometro, color: Color.Pink, lineWidth: 2);
            plot.XLabel("Resistência");
            plot.YLabel("Potenciômetro");
            plot.Title("Potenciômetro x Resistência");
            plot.SaveFig(output);
        }
    }
}
