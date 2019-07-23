package PacoteJava;
import javax.swing.JOptionPane;
public class Exemplo {

  public static void main (String[] args){

String A = JOptionPane.showInputDialog("Entre com um valor\n");
 int a = Integer.parseInt(A);
String B = JOptionPane.showInputDialog("Entre com o segundo valor\n");
int b = Integer.parseInt(B);
int resultado;

String x = JOptionPane.showInputDialog(null, "Escolha a opção desejada:\n1- Soma\n2-Subtração\n3-Multiplicação");
int escolha = Integer.parseInt(x);

switch(escolha){

  case 1 :
  resultado= a+b;
  System.out.println(resultado);
  break;

  case 2 :
  resultado= a-b;
  System.out.println(resultado);
  break;

  case 3 :
  resultado= a*b;
  System.out.println(resultado);
  break;

  default:
    System.out.println("Escolha errada");

}
System.exit(0);

  }
}
