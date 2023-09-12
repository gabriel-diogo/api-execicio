using api_execicio.modelo;
using api_execicio.repositorio;

namespace api_execicio;

public partial class MainPage : ContentPage
{
	private static string stipoveiculo;
    private static string codigomodelo;
    private static string anocar;
    private static string anorpesqui;
    public MainPage()
	{
		InitializeComponent(); caregartipo();

    }


	public void caregartipo()
	{
		pk1.Title = "selecione";
		pk1.ItemsSource=veiculorepositorios.listaveiculos();
		pk1.ItemDisplayBinding=new Binding("Tipo");
	}


	 void seltipo(object sender, EventArgs e)
	{
		var ptipo =(Picker)sender;
		int slecao = ptipo.SelectedIndex;
		if (slecao != -1) {
			
			veiculos veiculos = (veiculos)ptipo.ItemsSource[slecao];


			stipoveiculo = veiculos.Tipo;

			caregarfabricante (stipoveiculo);

        }
		
	}
    void selfabri(object sender, EventArgs e)
    {
        var pfab = (Picker)sender;
        int slecao = pfab.SelectedIndex;
        if (slecao != -1)
        {

            frabricantes fab = (frabricantes)pfab.ItemsSource[slecao];


            // stipoveiculo = veiculos.Tipo;

            //aregarfabricante(stipoveiculo);

            codigomodelo=fab.codigo;

            caregarmodelo(codigomodelo);

        }

    }

    void selano(object sender, EventArgs e)
    {
        var pano = (Picker)sender;
        int slecao = pano.SelectedIndex;
        if (slecao != -1)
        {

            modelos a = (modelos)pano.ItemsSource[slecao];


            // stipoveiculo = veiculos.Tipo;

            //aregarfabricante(stipoveiculo);

            anocar = a.codigo;

            caregarano(anocar);

        }
    }

        private void caregarano(string codigo)
        {
            pkano .Title = "selecione o ano";
            pkano .ItemsSource = aborepositorio.litaano(codigomodelo, stipoveiculo, anocar);
            pkano.ItemDisplayBinding = new Binding("nome");


        }

        private void caregarmodelo(string codigo)
	{
		pkmod.Title = "selecione o modelo";
		pkmod.ItemsSource = modelorepositorio.listamodelo(codigo, stipoveiculo);
		pkmod.ItemDisplayBinding = new Binding("nome");
	
	
	}

        private void caregarfabricante(string tpveiculo) {

		pkfab.Title = "select fabri";
		pkfab.ItemsSource = frabricanterepositorio.listafabricantes(tpveiculo);
		pkfab.ItemDisplayBinding = new Binding("nome");
	
	
	}


    void sel_ano_pesqui(object sender, EventArgs e)
    {
        var pano = (Picker)sender;
        int slecao = pano.SelectedIndex;
        if (slecao != -1)
        {

            ano a = (ano)pano.ItemsSource[slecao];


            // stipoveiculo = veiculos.Tipo;

            //aregarfabricante(stipoveiculo);

            anorpesqui = a.codigo;

            

        }
    }
    private void garg_dados(object sender, EventArgs e)
    {
        
        
        
            var t1= precorepositorio.retornadados(codigomodelo, stipoveiculo,anocar,anorpesqui).Valor;
        var t2 = precorepositorio.retornadados(codigomodelo, stipoveiculo, anocar, anorpesqui).Marca;
        var t3 = precorepositorio.retornadados(codigomodelo, stipoveiculo, anocar, anorpesqui).Anomodelo;
        var t4 = precorepositorio.retornadados(codigomodelo, stipoveiculo, anocar, anorpesqui).Combustivel;





        lbpreco.Text = t1+ ">" + t2 + ">" + t3 +">"+t4;
   
    }

}

