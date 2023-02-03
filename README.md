# APIs PIX do BCB

- [APIs PIX do BCB](#apis-pix-do-bcb)
- [Implementações:](#implementações)
  - [Banco Sicoob:](#banco-sicoob)

Repositório para comunicação via API para transações PIX

Repositório de PIX do Bacen: https://github.com/bacen/pix-api

Manual Swagger das APIs PIX: https://bacen.github.io/pix-api/index.html

Este repositório contém:
* Contratos (Interfaces) e as models para comunicação com os PSPs (bancos).
* Models para comunicação com os PSPs (bancos).
* Validações

Serão criados repositórios e pacotes para cada PSP

Pacote:
[![NuGet](https://buildstats.info/nuget/CS.BCB.PIX)](https://www.nuget.org/packages/CS.BCB.PIX)

Para saber a lista de PSPs que seguem o padrão, ou ter uma ideia de quanto do padrão é seguido por cada uma, 
veja a issue 76 do repostório do BACEN https://github.com/bacen/pix-api/issues/76

# Implementações:

## Banco Sicoob:

Repositório:
[![.NET](https://github.com/SharpSistemas/SicoobAPI/actions/workflows/dotnet.yml/badge.svg)](https://github.com/SharpSistemas/SicoobAPI)

Pacote:
[![NuGet](https://buildstats.info/nuget/Sicoob.PIX)](https://www.nuget.org/packages/Sicoob.PIX)


