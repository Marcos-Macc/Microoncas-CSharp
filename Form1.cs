namespace MicroOndas
{
    public partial class Form1 : Form
    {
        int pinTempo = 0;
        int pinPotencia = 0;
        int pinDecorrido = 0;
        string pstAquecer = ".";
        
        List<Programas> p;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void iniciaProcesso()
        {
            if (lbProgramas.SelectedIndex == 0)
            {
                if (edtEntrada.Text != "") 
                {
                    edtSaida.Text = edtEntrada.Text;
                    pinDecorrido = 0;
                    lblAquecida.Visible = false;
                    timerAquecendo.Enabled = true;
                }
                else
                {
                    throw new Exception("Entrada deve possuir texto.");

                }
            }
            else
            {
                if (edtEntrada.Text == "")
                {
                    edtEntrada.Text = p[lbProgramas.SelectedIndex].nome;
                }
                edtSaida.Text = edtEntrada.Text;
                pinDecorrido = 0;
                lblAquecida.Visible = false;
                timerAquecendo.Enabled = true;
            }
        }

        private void lbProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(lbProgramas.SelectedIndex);
            if (lbProgramas.SelectedIndex == 0) 
            {
                spnTempo.Value = 1;
                spnPotencia.Value = 10;
            }
            else
            {
                spnTempo.Value = p[lbProgramas.SelectedIndex].tempo;
                spnPotencia.Value = p[lbProgramas.SelectedIndex].potencia;
                edtInstrucoes.Text = p[lbProgramas.SelectedIndex].instrucoes;
                pstAquecer = p[lbProgramas.SelectedIndex].caractere;
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            pinTempo = (int)spnTempo.Value;
            pinPotencia = (int)spnPotencia.Value;
            iniciaProcesso();
        }

        private void btnInicioRapido_Click(object sender, EventArgs e)
        {
            pinTempo = 30;
            pinPotencia = 8;
            iniciaProcesso();
        }

        private void timerAquecendo_Tick(object sender, EventArgs e)
        {
            timerAquecendo.Enabled = false;
            aquece1Seg(pinTempo, pinPotencia);
        }
        public void aquece1Seg(int t, int pot)
        {
            String lstPontos = "";
            String pstSaida = edtSaida.Text;
            int i = 0;
            for (i = 0;i < pot ; i++)
            {
                lstPontos = lstPontos + pstAquecer;
            }


            pinDecorrido = pinDecorrido + 1;
            pstSaida = pstSaida + lstPontos;
            edtSaida.Text = pstSaida;

            if (pinDecorrido != t)
            { 
                timerAquecendo.Enabled = true;
            }
            else
                finalizar();


        }

        private void finalizar()
        {
            lblAquecida.Visible = true;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            var progs = new Programas();
            p = new List<Programas>();
            progs.Construtor(1, 10, "CUSTOM", "Customizado", "."); p.Add(progs); progs = new Programas();
            progs.Construtor(60, 5, "Frango", "Descrição Frango", "f"); p.Add(progs); progs = new Programas();
            progs.Construtor(80, 8, "Carne", "Descrição Carne", "c"); p.Add(progs); progs = new Programas();
            progs.Construtor(50, 4, "Peixe", "Descrição peixe", "p"); p.Add(progs); progs = new Programas();
            progs.Construtor(30, 3, "Feijão", "Descrição Feijão", "j"); p.Add(progs); progs = new Programas();
            progs.Construtor(40, 2, "Pipoca", "Descrição Pipoca", "i"); p.Add(progs);
        }
    }
}