using System.Collections.Generic;

public abstract class NotaFiscal
{
    public abstract void GerarNotaFiscal();
}

public class NotaDeRecebimentoDeMercadoria : NotaFiscal
{
    public override void GerarNotaFiscal() { /* Implementação da Nota de Recebimento */ }
}

public class NotaDeDevolucaoDeMercadoria : NotaFiscal
{
    public override void GerarNotaFiscal() { /* Implementação da Nota de Devolução */ }
}

public class ImpressaoDeNotas
{
    public void ImprimirNotas(IEnumerable<NotaFiscal> notas)
    {
        foreach (var notaFiscal in notas)
        {
            notaFiscal.GerarNotaFiscal();
        }
    }
}