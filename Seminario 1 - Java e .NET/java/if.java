package PacoteJava;
import javax.swing.*;


public class Exemplo {
  static int x, y;


  public static void main (String[] args){


    String X = JOptionPane.showInputDialog(null, "Insira o valor de x: ");
    x = Integer.parseInt(X);
    String Y = JOptionPane.showInputDialog(null, "Insira o valor de y: ");
    y = Integer.parseInt(Y);

    if(x>y){
      System.out.println(x + "é maior que" +y);


    }
    else {
      System.out.println(y + "é maior que" + x);
    }

System.exit(0);



  }

}
