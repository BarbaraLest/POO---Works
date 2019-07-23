package PacoteJava;
import javax.swing.JOptionPane;

public class Exemplo {
  static int x, y;

  public static void main (String[] args){
    String X = JOptionPane.showInputDialog(null, "Insira um valor: ");
    x = Integer.parseInt(X);
    int cont = 0;
    while(cont < x){
      System.out.println("exemplo");
      cont+=1;
  }
System.exit(0);
  }

}
