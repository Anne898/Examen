using System;

namespace Examen
{
    class Mochila
    {
        public Objetos[,] mochila;

        public Mochila(Objetos[,] mochila)
        {
            this.mochila = mochila;
        }


        public void Imprimir()
        {

            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 4; x++)
                {
                    Console.Write(mochila[i, x].GetInicial() + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine("Acomodo correcto");
        }

        public void VerificarPesos() //verifica pesos
        {

            int suma1 = mochila[0, 1].GetPeso() + mochila[1, 1].GetPeso(); //suma fila 1
            int suma2 = mochila[0, 2].GetPeso() + mochila[1, 2].GetPeso(); //suma fila 2


            if (mochila[0, 0].GetPeso() != 0 && mochila[0, 3].GetPeso() != 0)
            {
                Console.WriteLine("Ese espacio no puede ser utilizado u");
            }
            //FILA 0
            if (mochila[2, 0].GetPeso() < mochila[1, 0].GetPeso())
            {
                Console.WriteLine("Acomodo incorrecto, " + mochila[2, 0].GetNombre() + " esta siendo aplastado");
            }

            //FILA 3
            else if (mochila[2, 3].GetPeso() < mochila[1, 3].GetPeso())
            {
                Console.WriteLine("Acomodo incorrecto, " + mochila[2, 3].GetNombre() + " esta siendo aplastado");
            }

            else if (mochila[1, 1].GetPeso() < mochila[0, 1].GetPeso())
            {

                Console.WriteLine("Acomodo incorrecto, " + mochila[1, 1].GetNombre() + " esta siendo aplastado");

            }

            else if (mochila[2, 1].GetPeso() < mochila[1, 1].GetPeso())
            {

                Console.WriteLine("Acomodo incorrecto, " + mochila[2, 1].GetNombre() + " esta siendo aplastado");

            }


            else if (mochila[1, 2].GetPeso() < mochila[0, 2].GetPeso())
            {

                Console.WriteLine("Acomodo incorrecto, " + mochila[1, 2].GetNombre() + " esta siendo aplastado");

            }

            else if (mochila[2, 2].GetPeso() < mochila[1, 2].GetPeso())
            {

                Console.WriteLine("Acomodo incorrecto, " + mochila[2, 2].GetNombre() + " esta siendo aplastado");

            }


            //FILA 1

            else if (mochila[1, 1].GetPeso() == mochila[0, 1].GetPeso())
            {
                if (mochila[2, 1].GetPeso() < mochila[1, 1].GetPeso() || mochila[2, 1].GetPeso() < mochila[0, 1].GetPeso())
                {
                    Console.WriteLine("Acomodo incorrecto, " + mochila[2, 1].GetNombre() + " esta siendo aplastado");
                }

                else if (mochila[1, 1].GetPeso() != mochila[0, 1].GetPeso())
                {

                    if (mochila[1, 1].GetPeso() == mochila[2, 1].GetPeso())
                    {

                        if (mochila[1, 1].GetPeso() < mochila[0, 1].GetPeso() || mochila[2, 1].GetPeso() < mochila[0, 1].GetPeso())
                        {
                            Console.WriteLine("Acomodo incorrecto, " + mochila[1, 1].GetNombre() + " esta siendo aplastado");
                        }

                        else
                        {
                            Imprimir();
                        }

                    }
                }

            }

            //FILA 2


            else if (mochila[1, 2].GetPeso() == mochila[0, 2].GetPeso())
            {
                if (mochila[2, 2].GetPeso() < mochila[1, 2].GetPeso() || mochila[2, 2].GetPeso() < mochila[0, 2].GetPeso())
                {
                    Console.WriteLine("Acomodo incorrecto, " + mochila[2, 2].GetNombre() + " esta siendo aplastado");
                }

                else if (mochila[1, 2].GetPeso() != mochila[0, 2].GetPeso())
                {

                    if (mochila[1, 2].GetPeso() == mochila[2, 2].GetPeso())
                    {
                        if (mochila[1, 2].GetPeso() < mochila[0, 2].GetPeso() || mochila[2, 2].GetPeso() < mochila[0, 2].GetPeso())
                        {
                            Console.WriteLine("Acomodo incorrecto, " + mochila[1, 2].GetNombre() + " esta siendo aplastado");
                        }

                        else
                        {
                            Imprimir();
                        }

                    }
                }

            }


            else if (mochila[1, 1].GetPeso() != mochila[0, 1].GetPeso() && mochila[1, 1].GetPeso() != mochila[2, 1].GetPeso() && (mochila[2, 1].GetPeso() < suma1))
            {
                if (mochila[2, 1].GetPeso() < suma1)
                {

                    Console.WriteLine("Acomodo incorrecto, " + mochila[2, 1].GetNombre() + " esta siendo aplastado");
                }

                else
                {
                    Imprimir();
                }
            }


            else
            {
                Imprimir();
            }

        }

    }
}


