using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class NeuralNetworks
    {
        private Neuron neuron1;
        private Neuron neuron2;


        public NeuralNetworks()
        {
            //iki nöron objesi oluşturuyoruz
            neuron1 = new Neuron(25);
            neuron2 = new Neuron(25);
        }
        //matrisin 1 veya 2 olduğunu dönderen metod
        public int Predict(int[] girdiler)
        {
            double output1 = neuron1.sonuc(girdiler);
            double output2 = neuron2.sonuc(girdiler);
            return output1 > output2 ? 1 : 2;

        }
        //train metodu
        public void Train(int[][] trainingData, int[] labels, double learningRate, int epochs)
        {
            for (int epoch = 0; epoch < epochs; epoch++)//epoch değeri kadar tekrarlar
            {
                for (int i = 0; i < trainingData.Length; i++)
                {
                    int[] girdiler = trainingData[i];
                    int target = labels[i];//hedef(label)
                    //çıktıları alıyoruz
                    double output1 = neuron1.sonuc(girdiler);
                    double output2 = neuron2.sonuc(girdiler);

                    if (target == 1)//label=1 ise 1.nöronu train eder
                    {
                        if (output1 < output2)//hedef 1 iken ikinci nöronun çıktısı daha büyük ise nöron1 in ağırlığını arttırır nöron2 nin ağırlığını azaltır
                        {

                            neuron1.agirlikArttirma(girdiler, learningRate);
                            neuron2.agirlikAzaltma(girdiler, learningRate);

                        }

                    }
                    else
                    {//label=2 ise 2.nöronu train eder
                        if (output2 < output1)//hedef 2 iken birinci nöronun çıktısı daha büyük ise nöron2 in ağırlığını arttırır nöron1 nin ağırlığını azaltır
                        {
                            neuron2.agirlikArttirma(girdiler, learningRate);
                            neuron1.agirlikAzaltma(girdiler, learningRate);
                        }

                    }

                }

            }
        }
    }
}
