# Anotações Aula 35 - 29/05

serialização - organizar o objeto

A serialização é o processo de converter um objeto em uma sequência de bytes para que ele possa ser armazenado, transmitido ou persistido em um formato que possa ser recuperado posteriormente. A finalidade principal da serialização é preservar o estado de um objeto para recuperá-lo em outro momento, quando necessário.

fluxo de bytes = Stream of Bytes

Existem diferentes formas de serialização em .NET, e algumas das principais são:

1 - BinaryFormatter: É uma classe fornecida pelo namespace System.Runtime.Serialization.Formatters.Binary. Ela permite a serialização em formato binário, convertendo objetos em uma sequência de bytes. O método .Serialize é usado para serializar um objeto em um fluxo de saída, enquanto o método Deserialize é usado para desserializar um objeto a partir de um fluxo de entrada. O formato binário resultante é eficiente e pode ser usado para armazenamento local ou transferência entre aplicativos .NET. (serialização binária)

2- SOAP (Simple Object Access Protocol): É uma forma de serialização de objetos usando XML. É uma das primeiras formas de integração de serviços da web e é praticamente nativo do .NET. O SOAP permite a troca de informações estruturadas entre sistemas distribuídos. A serialização SOAP também é fornecida pelo namespace System.Runtime.Serialization.Formatters.Soap. Ela permite a serialização de objetos em formato SOAP usando XML, que pode ser transmitido entre diferentes sistemas. (serialização de texto)

3- JSON (JavaScript Object Notation) é um formato de dados leve e legível por humanos que é amplamente utilizado para troca de informações entre sistemas. Em .NET, a serialização JSON é comumente realizada usando a classe JsonSerializer da biblioteca Newtonsoft.Json (também conhecida como Json.NET), que é amplamente adotada e oferece recursos avançados de serialização e desserialização JSON.
Para serializar um objeto em JSON, você pode usar o método JsonConvert.SerializeObject(). Esse método converte um objeto em sua representação JSON correspondente.
A serialização em JSON é amplamente utilizada em cenários de comunicação entre sistemas, como APIs da web, serviços da web, transferência de dados entre aplicativos e armazenamento de dados em formato JSON. É uma forma eficiente e flexível de representar dados estruturados e tem suporte em várias plataformas e linguagens de programação.

4- A serialização XML usando as classes XmlSerializer e DataContractSerializer em .NET é uma forma de converter objetos em XML e vice-versa. Essa abordagem é útil para troca de dados estruturados entre sistemas, armazenamento em arquivos XML ou comunicação com serviços web que utilizam XML como formato de dados. A XmlSerializer é fácil de usar e oferece suporte a várias opções de personalização, como alterar os nomes dos elementos XML, ignorar propriedades durante a serialização ou especificar um formato personalizado para propriedades.

Ao escolher um método de serialização, é importante considerar o cenário de uso, os requisitos de desempenho, interoperabilidade com outras plataformas e a facilidade de uso.

É importante observar que nem todos os objetos podem ser serializados. Para que um objeto seja serializável, ele precisa ser marcado com o atributo [Serializable]. Isso indica ao mecanismo de serialização que o objeto pode ser convertido em uma sequência de bytes. Se um objeto não for marcado como serializável e uma tentativa de serialização for feita, uma exceção será lançada.

A serialização é uma técnica poderosa para armazenar e transferir objetos em .NET, permitindo que o estado de um objeto seja preservado e compartilhado entre diferentes momentos e contextos de execução. No entanto, é importante ter cuidado ao serializar objetos contendo dados sensíveis ou confidenciais, pois eles podem ser recuperados por outras partes e comprometer a segurança das informações.

---

Para garantir a legitimidade da serialização e proteger os arquivos de manipulação não autorizada, é recomendável adicionar uma forma de assinatura ou autenticação. Uma opção comum é o uso do HMAC (Hash-based Message Authentication Code), que é um algoritmo de autenticação de mensagem baseado em criptografia de hash.

A ideia principal por trás do HMAC é criar um código de autenticação (MAC - Message Authentication Code) que seja calculado a partir dos dados a serem autenticados e uma chave secreta compartilhada entre o remetente e o destinatário. O destinatário pode verificar a autenticidade dos dados recalculando o MAC usando a mesma chave e comparando-o com o valor recebido. Se o MAC recalculado coincidir com o valor recebido, isso indica que os dados não foram modificados e são autênticos.

Ao usar o HMAC para assinar arquivos de serialização, você pode garantir a integridade dos dados e a autenticidade do remetente. Isso é especialmente importante ao trabalhar com formatos mais seguros, como JSON e XML, onde a manipulação não autorizada ou a injeção de dados maliciosos podem ter consequências significativas.

A implementação do HMAC envolve as seguintes etapas:

- Escolha de um algoritmo de hash: O HMAC geralmente é implementado usando algoritmos de hash seguros, como SHA-256 ou SHA-512. Esses algoritmos produzem uma sequência de bytes única (hash) a partir dos dados fornecidos.

- Compartilhamento da chave: O remetente e o destinatário devem concordar com uma chave secreta compartilhada. Essa chave é usada tanto para calcular quanto para verificar o MAC.

- Cálculo do HMAC: O remetente calcula o HMAC dos dados a serem assinados usando a chave compartilhada e o algoritmo de hash selecionado. O resultado é anexado aos dados ou transmitido separadamente.

- Verificação do HMAC: O destinatário recebe os dados e a assinatura (MAC). Ele recalcula o HMAC usando a mesma chave e algoritmo de hash e compara o valor resultante com a assinatura recebida. Se eles corresponderem, isso indica que os dados não foram modificados e são autênticos.

É importante manter a chave secreta segura e compartilhá-la somente entre as partes autorizadas. O uso do HMAC não fornece confidencialidade dos dados, apenas garante a autenticidade e integridade dos mesmos.

Ao implementar o HMAC para assinar arquivos de serialização em JSON ou XML, você pode garantir a segurança dos dados transmitidos e a confiança na origem dos mesmos.
