package exemplojtable;
import java.awt.Color;
import javax.swing.SwingConstants;
import javax.swing.table.DefaultTableCellRenderer;
import javax.swing.table.DefaultTableModel;

/**
 * * @author Barbara
 */
public class Cliente extends javax.swing.JFrame {
 int num;
      public Cliente() {
        initComponents();
    }
   
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jDialog1 = new javax.swing.JDialog();
        jtNome = new javax.swing.JTextField();
        jtCurso = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        btnCadastrar = new javax.swing.JButton();
        btnExcluir = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        jtCadastro = new javax.swing.JTable();
        btnAtt = new javax.swing.JButton();

        javax.swing.GroupLayout jDialog1Layout = new javax.swing.GroupLayout(jDialog1.getContentPane());
        jDialog1.getContentPane().setLayout(jDialog1Layout);
        jDialog1Layout.setHorizontalGroup(
            jDialog1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 400, Short.MAX_VALUE)
        );
        jDialog1Layout.setVerticalGroup(
            jDialog1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 300, Short.MAX_VALUE)
        );

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Cadastro Aluno");
        getContentPane().setLayout(null);

        jtNome.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jtNomeActionPerformed(evt);
            }
        });
        getContentPane().add(jtNome);
        jtNome.setBounds(70, 40, 140, 30);
        getContentPane().add(jtCurso);
        jtCurso.setBounds(70, 90, 140, 30);

        jLabel1.setText("Nome:");
        getContentPane().add(jLabel1);
        jLabel1.setBounds(20, 40, 60, 20);

        jLabel2.setText("Curso:");
        getContentPane().add(jLabel2);
        jLabel2.setBounds(20, 90, 50, 20);

        btnCadastrar.setText("Cadastrar");
        btnCadastrar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCadastrarActionPerformed(evt);
            }
        });
        getContentPane().add(btnCadastrar);
        btnCadastrar.setBounds(40, 190, 120, 30);

        btnExcluir.setText("Excluir");
        btnExcluir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnExcluirActionPerformed(evt);
            }
        });
        getContentPane().add(btnExcluir);
        btnExcluir.setBounds(180, 190, 120, 30);

        jtCadastro.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Nome", "Curso"
            }
        ));
        jScrollPane1.setViewportView(jtCadastro);

        getContentPane().add(jScrollPane1);
        jScrollPane1.setBounds(20, 300, 330, 190);

        btnAtt.setText("Atualizar");
        btnAtt.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAttActionPerformed(evt);
            }
        });
        getContentPane().add(btnAtt);
        btnAtt.setBounds(40, 250, 130, 30);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jtNomeActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jtNomeActionPerformed
      
    }//GEN-LAST:event_jtNomeActionPerformed

    public void Formatação()
    {
        DefaultTableCellRenderer centralizado = new DefaultTableCellRenderer(); 
        centralizado.setHorizontalAlignment(SwingConstants.CENTER);
        jtCadastro.getColumnModel().getColumn(0).setCellRenderer(centralizado);
        jtCadastro.getColumnModel().getColumn(1).setCellRenderer(centralizado);

   
      
        DefaultTableCellRenderer cor = new DefaultTableCellRenderer(); 
        cor.setForeground(Color.RED);
        jtCadastro.getColumnModel().getColumn(1).setCellRenderer(cor);
    
    }
    
    
    public void Cadastrar()
    {
    //comandos para os dados inseridos na text box serem apagados
       
        //atribuição do conteudo das texts boxs para variaveis
        String nome = jtNome.getText().trim();
        String curso = jtCurso.getText().trim();
        
        //A classe a seguir servira para alimentar a Jtable
        DefaultTableModel val = (DefaultTableModel) jtCadastro.getModel();
        /*Pegamos as informações fornecidas do usuario e atribuimos ela em um array para que 
        elas possam ser exibidas na jtable */
        val.addRow(new String[]{nome, curso});
    }
    
    private void btnCadastrarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCadastrarActionPerformed
        Cadastrar();            
        jtNome.setText("");
        jtCurso.setText("");        
        Formatação();
   
        
    }//GEN-LAST:event_btnCadastrarActionPerformed

    
    public void Excluir()
    {
        ((DefaultTableModel) jtCadastro.getModel()).removeRow(jtCadastro.getSelectedRow());
    }
    
    private void btnExcluirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnExcluirActionPerformed
        Excluir();
    }//GEN-LAST:event_btnExcluirActionPerformed

    public void Att()
    {
    
        num = jtCadastro.getSelectedRow();
        jtNome.setText(jtCadastro.getValueAt(num, 0).toString());
        jtCurso.setText(jtCadastro.getValueAt(num, 1).toString());
       Excluir();

    }
    
    
    
    private void btnAttActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAttActionPerformed
           
     
         Att();
      
        
        
        
        
        
    }//GEN-LAST:event_btnAttActionPerformed


    
    
    public static void main(String args[]) {
        
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Cliente().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnAtt;
    private javax.swing.JButton btnCadastrar;
    private javax.swing.JButton btnExcluir;
    private javax.swing.JDialog jDialog1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable jtCadastro;
    private javax.swing.JTextField jtCurso;
    private javax.swing.JTextField jtNome;
    // End of variables declaration//GEN-END:variables

   
}
