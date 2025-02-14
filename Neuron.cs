using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NeuralNetwork
{
    public class Neuron
    {
        public double[] agirliklar;
        public Random random = new Random();
        public Neuron(int matrixSize)
        {
            //ağırlıkları ilk başta rastgele veriyoruz
            agirliklar = new double[matrixSize];
            for (int i = 0; i < matrixSize; i++)
            {
                agirliklar[i] = random.NextDouble();//0 ile 1 arasında double
            }
        }
        //nöron çıktısı verir
        public double sonuc(int[] girdiler)
        {
            double sum = 0;
            for (int i = 0; i < girdiler.Length; i++)
            {
                sum += girdiler[i] * agirliklar[i];
            }
            //Console.WriteLine(sum);

            return sum;

        }
        //ağırlığı arttırma metodu
        public void agirlikArttirma(int[] girdiler, double learningRate)
        {
            for (int i = 0; i < agirliklar.Length; i++)
            {
                agirliklar[i] = agirliklar[i] + (learningRate * girdiler[i]);
            }
        }
        //ağırlığı azaltma metodu
        public void agirlikAzaltma(int[] girdiler, double learningRate)
        {
            for (int i = 0; i < agirliklar.Length; i++)
            {
                agirliklar[i] = agirliklar[i] - (learningRate * girdiler[i]);
            }
        }


    }
}

