use Norten
go

CREATE PROCEDURE InserirFolhaDePagamento 
    @Conta NVARCHAR(100),
    @SalarioBase DECIMAL(10, 2),
    @AdicionalNoturno DECIMAL(10, 2),
    @AdiantamentoQuinzenal DECIMAL(18, 2),
    @PlanoDeSaude DECIMAL(18, 2),
    @INSS DECIMAL(18, 2),
    @ValeRefeicao DECIMAL(18, 2),
    @ValeTransporte DECIMAL(18, 2),
    @FGTS DECIMAL(18, 2),
    @DecimoTerceiro DECIMAL(18, 2),
    @Ferias DECIMAL(18, 2),
    @ID_Func INT
AS
BEGIN
    INSERT INTO FolhaDePagamento 
    (Conta, SalarioBase, AdicionalNoturno, AdiantamentoQuinzenal, 
     PlanoDeSaude, INSS, ValeRefeicao, ValeTransporte, FGTS, 
     DecimoTerceiro, Ferias, ID_Func)
    VALUES 
    (@Conta, @SalarioBase, @AdicionalNoturno, @AdiantamentoQuinzenal, 
     @PlanoDeSaude, @INSS, @ValeRefeicao, @ValeTransporte, @FGTS, 
     @DecimoTerceiro, @Ferias, @ID_Func);
END

EXEC InserirFolhaDePagamento 
    @Conta = 'Conta do Funcionário',
    @SalarioBase = 5000.00,
    @AdicionalNoturno = 100.00,
    @AdiantamentoQuinzenal = 50.00,
    @PlanoDeSaude = 200.00,
    @INSS = 1200.00,
    @ValeRefeicao = 1000.00,
    @ValeTransporte = 4000.00,
    @FGTS = 4000.00,
    @DecimoTerceiro = 666.67,
    @Ferias = 3333.33,
    @ID_Func = 1;
