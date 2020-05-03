namespace ApiTwilio.Domain
{
  public static class InitialService
  {
    public static string Start(string data)
    {
      var request = data.ToLowerInvariant();

      if (request.Contains("iniciar") || request.Contains("compra"))
      {
        return @"Seja bem vindo ao atendimento automatizado da VTEX! Vou te passar todos os setores! *Lembre-se, para escolher um setor digite: Setor 51, por exemplo*

            Setor 1: *Eletronicos*
            Setor 2: *Informatica*
            Setor 3: *Cama, mesa e banho*

        ";
      }
      else if (request.Contains("setor"))
      {
        var messageParams = data.Split(' ');

        if (messageParams.Length == 1)
        {
          return "Ops! Tente digitar nesse formato: *Setor 12*, por exemplo";
        }
        else
        {
          if (int.Parse(messageParams[1]) == 1)
          {
            return $@"Setor escolhido: {messageParams[1]}, aqui estão seus produtos:
            
              - 231 : Televisão 42 polegadas
              - 2123 : Televisão 29 polegadas
              - 354 : Televisão 54 polegadas
              - 43412: Televisão 32 polegadas
              
            Para selecionar um produto digite: *Escolher produto 231*, por exemplo";
          }
          else if (int.Parse(messageParams[1]) == 2)
          {
            return $@"Setor escolhido: {messageParams[1]}, aqui estão seus produtos:
            
              - 231 : Impressora multifuncional
              - 2123 : Cartucho tinta colorida
              - 354 : Mouse sem fio
              - 43412: Mouse com fio
              
            Para selecionar um produto digite: *Escolher produto 231*, por exemplo";
          }

          else
          {
            return $@"Setor escolhido: {messageParams[1]}, aqui estão seus produtos:
            
              - 231 : Jogo de toalha completo
              - 2123 : Travesseiro pena de ganso
              - 354 : Cortina PVC
              - 43412: Coberdrom
              
            Para selecionar um produto digite: *Escolher produto 231*, por exemplo";
          }
        }
      }
      else if (request.Contains("produto"))
      {
        var messageParams = data.Split(' ');

        if (messageParams.Length != 3)
        {
          return "Ops! Tente digitar nesse formato: *comprar produto 12*, por exemplo";
        }
        else
        {
          return $@"O produto {messageParams[2]} foi selecionado, escolha a forma de pagamento:
            1 - A vista (depósito)
            2 - A vista (debito)
            3 - Parcelado (cartão)
            4 - Parcelado (carnê)

            Para selecionar digite: *Pagar usando 4*.
          ";
        }
      }
      else if (request.Contains("pagar"))
      {
        var messageParams = data.Split(' ');

        if (messageParams.Length != 3)
        {
          return "Ops! Tente digitar nesse formato: *Pagar usando 4*, por exemplo";
        }
        else
        {
          return $@"Forma de pagamento {messageParams[2]} escolhida, foi enviado um e-mail contendo os dados para pagemento. 
          
            A VTEX agradece!😁
          ";
        }
      }
      else
      {
        return "Seja bem vindo ao atendimento automatizado da VTEX! Não entendi o que quis dizer, tente escrever algo como: *Quero comprar!*";
      }
    }
  }
}