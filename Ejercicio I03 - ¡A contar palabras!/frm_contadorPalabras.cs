using System.Text;

namespace Ejercicio_I03____A_contar_palabras_
{
    public partial class frm_contadorPalabras : Form
    {
        private Dictionary<string, int> diccionario;
        private List<string> palabrasLista;

        public frm_contadorPalabras()
        {
            InitializeComponent();
            diccionario = new Dictionary<string, int>();
            palabrasLista = new List<string>();
        }

        private void btn_calcular_Click_1(object sender, EventArgs e)
        {
            ContarPalabras(rtbx_entrada.Text);

            MessageBox.Show(Mostrar());
        }

        public void ContarPalabras(string texto)
        {
            char[] separacion = new char[] { ' ', ',', '.', ':', '\t' };
            palabrasLista.AddRange(texto.Split(separacion, StringSplitOptions.RemoveEmptyEntries));

            foreach (string palabra in palabrasLista)
            {
                if (!diccionario.ContainsKey(palabra) && palabra != " ")
                {
                    diccionario.Add(palabra, 1);
                }
                else
                {
                    diccionario[palabra] += 1;
                }
            }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            string eliminar = "";

            while (i < 3)
            {
                foreach (KeyValuePair<string, int> elemento in diccionario)
                {
                    if (diccionario.Values.Max() == elemento.Value && i < 3)
                    {
                        eliminar = elemento.Key;
                        sb.AppendLine($"{elemento.Key}   {elemento.Value}");
                        break;
                    }
                }

                if (diccionario.Remove(eliminar))
                {
                    i++;
                }
            }

            return sb.ToString();
        }

    }
}