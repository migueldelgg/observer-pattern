# Observer Pattern - Exemplo em C#

Este projeto é uma implementação prática do **Observer Pattern** (também conhecido como **Publish-Subscribe** ou **Pub/Sub**) utilizando **C# e .NET 8**.  
O exemplo simula um sistema de monitoramento de preços de **Bitcoin**, onde diferentes serviços reagem automaticamente quando o preço muda.

---

## O que é o Observer Pattern?

O **Observer Pattern** é um padrão de projeto comportamental que define uma relação **um-para-muitos** entre objetos.  
Quando o **Subject** (sujeito observado) muda de estado, todos os seus **Observers** (observadores inscritos) são notificados automaticamente.

👉 Em resumo:

- O **Subject** mantém uma lista de interessados (observers).  
- Quando algo muda, ele dispara uma notificação.  
- Cada **Observer** decide o que fazer com essa atualização.  

---

## Por que usar?

- **Desacoplamento**: o Subject não precisa conhecer os detalhes dos Observers.  
- **Extensibilidade**: é fácil adicionar novos observers sem alterar o código do Subject.  
- **Reatividade**: ideal para sistemas em tempo real (ex: cotações, eventos de UI, notificações).  

---

## Quando usar?

Use o **Observer Pattern** quando:

- Você precisa notificar automaticamente múltiplos componentes sobre mudanças de estado.  
- Deseja evitar **polling** (consulta contínua e manual ao estado).  
- Quer manter um **baixo acoplamento** entre as partes do sistema.  

Exemplos práticos:

- Notificações em tempo real (ex: push de preço de criptomoeda).  
- Atualização de interface gráfica (UI) quando dados mudam.  
- Sistemas de eventos e mensageria.  
- Monitoramento (logs, alertas, métricas).

## Estrutura do Projeto

```
observer-pattern/
├── Criptocurrency/
│   ├── BinanceAPI.cs         # Simula API que fornece preço do Bitcoin
│   └── Bitcoin.cs            # Subject que notifica observers quando o preço muda
├── Service/
│   ├── BitcoinPriceLogger.cs # Observer: loga sempre que há atualização
│   ├── InvestorNotify.cs     # Observer: notifica investidores em grandes variações
│   ├── NewsPlatform.cs       # Observer: publica notícias em variações ainda maiores
│   └── Interface/
│       └── BitcoinPriceObserver.cs # Interface base para todos os observers
├── Program.cs                # Ponto de entrada da aplicação
├── observer-pattern.csproj
└── README.md
```

## Referências
- https://refactoring.guru/design-patterns/observer
