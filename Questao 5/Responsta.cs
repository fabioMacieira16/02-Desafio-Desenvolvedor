using System;

class Program {
    static void Main(string[] args) {
        // Faturamento mensal da distribuidora por estado
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 19849.53;
        
        // Calcula o faturamento total mensal da distribuidora
        double faturamentoTotal = sp + rj + mg + es + outros;
        
        // Calcula o percentual de representação de cada estado no faturamento total mensal da distribuidora
        double percSP = (sp / faturamentoTotal) * 100;
        double percRJ = (rj / faturamentoTotal) * 100;
        double percMG = (mg / faturamentoTotal) * 100;
        double percES = (es / faturamentoTotal) * 100;
        double percOutros = (outros / faturamentoTotal) * 100;
        
        // Exibe os resultados na tela
        Console.WriteLine("Percentual de representação do faturamento mensal por estado:");
        Console.WriteLine("SP: " + percSP.ToString("F2") + "%");
        Console.WriteLine("RJ: " + percRJ.ToString("F2") + "%");
        Console.WriteLine("MG: " + percMG.ToString("F2") + "%");
        Console.WriteLine("ES: " + percES.ToString("F2") + "%");
        Console.WriteLine("Outros: " + percOutros.ToString("F2") + "%");
    }
}