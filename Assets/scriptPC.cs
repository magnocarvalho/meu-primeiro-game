using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPC : MonoBehaviour
{
    public float velocidade;
    private float largura;
    private float altura;
    private int contador = 0;
    //Criando uma variável que servirá como referências ao RigidBody do meu objeto de jogo.
    private Rigidbody2D rbd;

    // Start is called before the first frame update
    //Isso se chama método.
    //Todos os comandos dentro de um método são executados quando ele é chamado,
    //O método Start é executado sempre que o jogo começa.
    //Então, aqui a gente coloca comandos que servem, de alguma forma, para a gente fazer a configuração inicial que seja preciso
    void Start()
    {
        //largura = size * proporção da tela
        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;
        //Aqui, eu estou pedindo para o programa buscar o RigidBody deste objeto de jogo. Uma vez que o programa encontre ele, a variável
        //rbd vai "receber" esse RigidBody. Em outras palavras: o rbd passa a representar o Rigidbody deste objeto de jogo.
        //Eu só preciso fazer isso uma vez. Depois disso, rbd sempre estará representando o RigidBody. Por isso esse comando está no método start
        rbd = GetComponent<Rigidbody2D>();
   
    }

    // Update is called once per frame
    //O método update é executado a cada atualização da tela! 
    //Aqui, a gente coloca comandos que sempre devem ser executados, como comandos para verificar se o jogador está apertando um botão
    void Update()
    {
        //No começo, esses comandos podem assustar um pouco, mas depois de um tempo fica fácil porque eles seguem um padrão

        //O objetivo, aqui, é fazer a sua nave (que é um objeto de jogo) se mover.
        //O primeiro passo do programa é verificar se o jogador está apertando algum botão (de seta para os lados ou para cima e para baixo)
        //O comando que verifica isso é o Input.GetAxis(). Se estiver escrito "Horizontal", o comando vai verificar se alguma seta de esquerda 
        //direita está sendo apertada. Se estiver escrito "Vertical", o programa vai verificar se tem uma seta para cima ou para baixo sendo apertada
        //Esse comando vai retornar um valor entre -1 e 1. 
        //Vamos pegar o exemplo do código abaixo "Horizontal" (direita e esquerda). Se o jogador não estiver apertando nenhuma das duas setas, o 
        //comando vai retornar o valor 0. Se o jogador apertar o botão da esquerda, o comando retorna o valor -1. Se o jogador apertar o botão da direita
        //o comando retorna o valor 1. Em seguida, a variável dirX vai receber esse valor (o valor vai ser armazenado na variável dirX para ser usado
        //depois
        float dirX = Input.GetAxis("Horizontal");
        float dirY = Input.GetAxis("Vertical");
      
        if (transform.position.x > largura)
            transform.position = new Vector2(-largura,transform.position.y);
        else if(transform.position.x < -largura)
            transform.position = new Vector2(largura, transform.position.y);
        if (transform.position.y > 0 && dirY>0 || transform.position.y < -altura && dirY < 0)
            dirY = 0;

        //transform.Translate(new Vector2(dirX,dirY)*Time.deltaTime * velocidade);
        //Aqui, o programa vai inserir uma velocidade ao seu objeto de jogo.
        //Velocidade faz parte da física. Para que um objeto possa sofrer ação da física, o programador tem que anexar um componente de física
        //(que já existe no Unity) chamado RigidBody2D. Esse componente já tem um monte de código de programa pronto para a gente usar.
        //Então, agora dá para aplicar uma velocidade ao rbd (que representa o rigidbody) e o objeto do jogo (que é a sua nave) se moverá
        //A velocidade é representada com duas dimensões (do eixo x e do eixo y). Há um tipo de variáveis que se chama Vector2, que permite que
        //voce armazene dois valores (que será a velocidade que você quer aplicar no eixo x e a velocidade que você que aplicar no eixo y).
        //A criação dessa variável é o new Vector2(valordex, valor de y)
        rbd.velocity = new Vector2(dirX,dirY)*velocidade;
    }
}
