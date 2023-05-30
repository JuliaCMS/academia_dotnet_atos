# Anotações Aula 36 - 30/05

## CRIPTOGRAFIA

A criptografia é o processo de transformar informações legíveis em uma forma ilegível chamada de texto cifrado, com o objetivo de proteger a confidencialidade e a integridade dos dados.

Existem diferentes tipos de criptografia, sendo os dois principais:

- Chave simétrica: nesse tipo de criptografia, a mesma chave é usada tanto para criptografar quanto para descriptografar os dados. A chave é compartilhada entre o remetente e o destinatário de forma segura. Algoritmos comuns de criptografia simétrica incluem o DES (Data Encryption Standard), 3DES (Triple DES) e AES (Advanced Encryption Standard). O AES é considerado um dos algoritmos mais seguros atualmente.

- Chave assimetrica (ou Criptografia de Chave Pública): são vinculadas matematicamente, são grandes numeros emparelhados. Nesse tipo de criptografia, duas chaves diferentes estão envolvidas: uma chave pública e uma chave privada. A chave pública é usada para criptografar os dados, enquanto a chave privada é usada para descriptografá-los. A chave pública pode ser compartilhada livremente, enquanto a chave privada deve ser mantida em segredo. O RSA é um algoritmo de criptografia de chave pública amplamente utilizado.

Além dos algoritmos mencionados, existem muitos outros algoritmos de criptografia disponíveis, como Twofish, Blowfish, ECC (Elliptic Curve Cryptography) e muitos mais. A escolha do algoritmo de criptografia depende dos requisitos de segurança, desempenho e compatibilidade do sistema em questão.

É importante notar que a criptografia por si só não garante a autenticidade dos dados. Para garantir a legitimidade da comunicação e evitar a falsificação de dados, é necessário o uso de técnicas de autenticação, como assinaturas digitais ou HMAC (autenticação de mensagem com chave de hash).
