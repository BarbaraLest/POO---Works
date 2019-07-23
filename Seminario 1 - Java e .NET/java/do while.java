package PacoteJava;
import javax.swing.JOptionPane;

public class Exemplo {
  public static void main (String[] args){

String A = JOptionPane.showInputDialog("Entre com um valor\n");
int a = Integer.parseInt(A);

do
   {
         System.out.println("Numero: " +a);

               a= a-1;

           } while (a > 0);

           System.exit(0);
}



  }
