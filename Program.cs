using System;

namespace NeuralNetwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nöral network objesini oluşturduk
            NeuralNetworks network = new NeuralNetworks();


            int[][,] trainingDataTwoD = new int[20][,];
            int[] labels = new int[20];

            //"bir" veri seti ve labelleri
            trainingDataTwoD[0] = new int[5, 5] {
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 1, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 }
                                           };
            labels[0] = 1;

            trainingDataTwoD[1] = new int[5, 5] {
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 1, 1, 0, 0 },
                                            { 1, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 }
                                            };
            labels[1] = 1;

            trainingDataTwoD[2] = new int[5, 5] {
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 1, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 1, 1, 1, 0 }
                                            };
            labels[2] = 1;

            trainingDataTwoD[3] = new int[5, 5] {
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 1, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 1, 1, 1, 1, 1 }
                                            };
            labels[3] = 1;

            trainingDataTwoD[4] = new int[5, 5] {
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 1, 1, 0, 0 },
                                            { 1, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 1, 1, 1, 0 }
                                            };
            labels[4] = 1;

            trainingDataTwoD[5] = new int[5, 5] {
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 1, 1, 0, 0 },
                                            { 1, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 1, 1, 1, 1, 1 }
                                            };
            labels[5] = 1;

            trainingDataTwoD[6] = new int[5, 5] {
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 }
                                            };
            labels[6] = 1;

            trainingDataTwoD[7] = new int[5, 5] {
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 1, 1, 1, 0 }
                                            };
            labels[7] = 1;

            trainingDataTwoD[8] = new int[5, 5] {
                                            { 0, 0, 0, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 1, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 }
                                            };
            labels[8] = 1;



            //"iki" veri seti ve labelleri
            trainingDataTwoD[9] = new int[5, 5] {
                                            { 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 },
                                            { 0, 0, 1, 0, 0 }
                                            };
            labels[9] = 1;


            trainingDataTwoD[10] = new int[5, 5] {
                                                { 0, 1, 1, 0, 0 },
                                                { 1, 0, 0, 1, 0 },
                                                { 0, 0, 1, 0, 0 },
                                                { 0, 1, 0, 0, 0 },
                                                { 0, 1, 1, 1, 0 }
                                            };
            labels[10] = 2;

            trainingDataTwoD[11] = new int[5, 5] {
                                                { 0, 1, 1, 0, 0 },
                                                { 1, 0, 0, 1, 0 },
                                                { 0, 0, 1, 0, 0 },
                                                { 0, 1, 0, 0, 0 },
                                                { 1, 1, 1, 1, 0 }
                                            };
            labels[11] = 2;

            trainingDataTwoD[12] = new int[5, 5] {
                                                { 0, 1, 1, 0, 0 },
                                                { 1, 0, 0, 1, 0 },
                                                { 0, 0, 1, 0, 0 },
                                                { 0, 1, 0, 0, 0 },
                                                { 1, 1, 1, 1, 1 }
                                            };
            labels[12] = 2;

            trainingDataTwoD[13] = new int[5, 5] {
                                                { 0, 1, 1, 0, 0 },
                                                { 1, 0, 0, 1, 0 },
                                                { 0, 0, 1, 1, 0 },
                                                { 0, 1, 0, 0, 0 },
                                                { 1, 1, 1, 1, 1 }
                                            };
            labels[13] = 2;

            trainingDataTwoD[14] = new int[5, 5] {
                                                { 0, 1, 1, 0, 0 },
                                                { 1, 0, 0, 1, 0 },
                                                { 0, 0, 1, 1, 0 },
                                                { 0, 1, 0, 0, 0 },
                                                { 0, 1, 1, 1, 0 }
                                            };
            labels[14] = 2;

            trainingDataTwoD[15] = new int[5, 5] {
                                                { 0, 1, 1, 1, 0 },
                                                { 0, 0, 0, 1, 0 },
                                                { 0, 1, 1, 1, 0 },
                                                { 0, 1, 0, 0, 0 },
                                                { 0, 1, 1, 1, 0 }
                                            };
            labels[15] = 2;

            trainingDataTwoD[16] = new int[5, 5] {
                                                { 0, 0, 1, 0, 0 },
                                                { 0, 1, 0, 1, 0 },
                                                { 0, 0, 0, 1, 0 },
                                                { 0, 0, 1, 0, 0 },
                                                { 0, 0, 1, 1, 0 }
                                            };
            labels[16] = 2;

            trainingDataTwoD[17] = new int[5, 5] {
                                                { 0, 0, 1, 0, 0 },
                                                { 0, 1, 0, 1, 0 },
                                                { 0, 0, 0, 1, 0 },
                                                { 0, 0, 1, 0, 0 },
                                                { 0, 0, 1, 1, 1 }
                                            };
            labels[17] = 2;

            trainingDataTwoD[18] = new int[5, 5] {
                                                { 0, 1, 1, 1, 0 },
                                                { 0, 1, 0, 1, 0 },
                                                { 0, 0, 0, 1, 0 },
                                                { 0, 0, 1, 0, 0 },
                                                { 0, 1, 1, 1, 1 }
                                            };
            labels[18] = 2;

            trainingDataTwoD[19] = new int[5, 5] {
                                                { 0, 0, 1, 1, 1 },
                                                { 0, 1, 0, 0, 1 },
                                                { 0, 0, 0, 1, 0 },
                                                { 0, 0, 1, 0, 0 },
                                                { 0, 1, 1, 1, 1 }
                                            };
            labels[19] = 2;

            // int[][,] tipini int[][] tipnine dönüştürüyorum

            int[][] jaggedDonustur(int[][,] matrix, int lenght)
            {
                int[][] twoDarray = new int[lenght][];
                for (int i = 0; i < lenght; i++)
                {
                    twoDarray[i] = TekBoyutYap(matrix[i]);
                }
                return twoDarray;
            }
            //iki boyutlu matrixi tek boyuta düşürme metodu
             int[] TekBoyutYap(int[,] matrix)
            {

                int[] liste = new int[25];

                int index = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        liste[index++] = matrix[i, j];
                    }
                }

                return liste;
            }
            int[][] trainingData = jaggedDonustur(trainingDataTwoD, 20);
            // training constantları
            double learningRate = 0.0003;
            int epochs = 80;
            //veri setiyle nöral ağı eğitiyoruz
            network.Train(trainingData, labels, learningRate, epochs);

            // Test kısmı 
            int correctPredictions = 0;
            for (int i = 0; i < trainingData.Length; i++)
            {
                int prediction = network.Predict(trainingData[i]);
                Console.WriteLine($"Hedef: {labels[i]}, Tahmin: {prediction}");
                if (prediction == labels[i]) correctPredictions++;
            }
            //doğruluk yüzdesi
            double accuracy = (double)correctPredictions / trainingData.Length * 100;
            Console.WriteLine($"Doğruluk: {accuracy}%");

            //tanıtılmayan veri
            int[][,] strangeDataTwoD = new int[3][,];
            int[] strangeLabels = new int[3];
            strangeDataTwoD[0] = new int[5, 5] {
                                                { 0, 0, 1, 1, 0 },
                                                { 0, 1, 1, 0, 0 },
                                                { 1, 0, 1, 0, 0 },
                                                { 0, 0, 1, 0, 0 },
                                                { 1, 1, 1, 1, 1 }
                                               };

            strangeLabels[0] = 1;

            strangeDataTwoD[1] = new int[5, 5] {
                                                { 1, 1, 1, 1, 0 },
                                                { 1, 0, 0, 1, 0 },
                                                { 1, 0, 1, 1, 0 },
                                                { 1, 0, 1, 0, 0 },
                                                { 0, 0, 1, 1, 1 }
                                               };
            strangeLabels[1] = 2;

            strangeDataTwoD[2] = new int[5, 5] {
                                                { 0, 0, 0, 1, 1 },
                                                { 0, 0, 1, 0, 1 },
                                                { 0, 1, 0, 0, 1 },
                                                { 1, 0, 0, 0, 1 },
                                                { 0, 0, 0, 0, 1 }
                                               };
            strangeLabels[2] = 1;
            int[][] strangeData = jaggedDonustur(strangeDataTwoD, 3);
            Console.WriteLine($"epoch:{epochs}");
            Console.WriteLine($"learningRate:{learningRate}");
            Console.WriteLine("SONUÇ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"hedef:{strangeLabels[i]}  Tahmin:{network.Predict(strangeData[i])}");
            }
            Console.ReadKey();
        }
    }
}