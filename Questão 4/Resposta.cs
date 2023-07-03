using System;

class Program {
    static void Main(string[] args) {
        // Vetor que guarda o faturamento diário ao longo de um ano (365 dias)
        double[] faturamentoDiario = { 1000, 2000, 1500, 0, 0, 3000, 2500, 1200, 1800, 2100 };
        
        // Variáveis para armazenar o menor e o maior valor de faturamento
        double menorFaturamento = double.MaxValue;
        double maiorFaturamento = double.MinValue;
        
        // Variável para armazenar o total de faturamento no ano (desconsiderando os dias sem faturamento)
        double totalFaturamento = 0;
        int diasComFaturamento = 0;
        
        // Percorre o vetor de faturamento diário
        for (int i = 0; i < faturamentoDiario.Length; i++) {
            // Atualiza o menor e o maior valor de faturamento
            if (faturamentoDiario[i] < menorFaturamento) {
                menorFaturamento = faturamentoDiario[i];
            }
            if (faturamentoDiario[i] > maiorFaturamento) {
                maiorFaturamento = faturamentoDiario[i];
            }
            
            // Verifica se o dia teve faturamento e, se sim, atualiza as variáveis para cálculo da média anual
            if (faturamentoDiario[i] > 0) {
                totalFaturamento += faturamentoDiario[i];
                diasComFaturamento++;
            }
        }
        
        // Calcula a média anual de faturamento
        double mediaAnual = totalFaturamento / diasComFaturamento;
        
        // Variável para armazenar o número de dias com faturamento superior à média anual
        int diasAcimaDaMedia = 0;
        
        // Percorre novamente o vetor de faturamento diário para contar os dias com faturamento superior à média anual
        for (int i = 0; i < faturamentoDiario.Length; i++) {
            if (faturamentoDiario[i] > mediaAnual) {
                diasAcimaDaMedia++;
            }
        }
        
        // Exibe os resultados na tela
        Console.WriteLine("Menor faturamento diário: " + menorFaturamento);
        Console.WriteLine("Maior faturamento diário: " + maiorFaturamento);
        Console.WriteLine("Número de dias com faturamento acima da média anual: " + diasAcimaDaMedia);
    }
}