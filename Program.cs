using System;
using System.Drawing;
using CircuitosLab03.Plot;

namespace CircuitosLab03
{
    class Program
    {
        static void Main(string[] args)
        {
            PotenciaPorResistencia potenciaPorResistencia = new PotenciaPorResistencia();
            potenciaPorResistencia.Plot("./PotenciaResistencia.png");

            EficienciaPorResistencia eficienciaPorResistencia = new EficienciaPorResistencia();
            eficienciaPorResistencia.Plot("./EficienciaResistencia.png");
        }
    }
}
