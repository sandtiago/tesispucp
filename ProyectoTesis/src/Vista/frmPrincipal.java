package Vista;

public class frmPrincipal extends javax.swing.JFrame {

    frmBienvenida ventanaBienvenida;

    public frmPrincipal(frmBienvenida vBienvenida) {
        initComponents();
        this.ventanaBienvenida = vBienvenida;
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        mbrPrincipal = new javax.swing.JMenuBar();
        mnuInicio = new javax.swing.JMenu();
        mnuAbrirHC = new javax.swing.JMenuItem();
        mnuCita = new javax.swing.JMenuItem();
        mnuCambiarContrasena = new javax.swing.JMenuItem();
        mnuCerrarSesion = new javax.swing.JMenuItem();
        mnuPaciente = new javax.swing.JMenu();
        mnuTriage = new javax.swing.JMenuItem();
        mnuHC = new javax.swing.JMenuItem();
        mnuHIS = new javax.swing.JMenuItem();
        mnuPersonal = new javax.swing.JMenu();
        mnuDoctor = new javax.swing.JMenuItem();
        mnuEnfermero = new javax.swing.JMenuItem();
        mnuTecnico = new javax.swing.JMenuItem();
        mnuAdministracion = new javax.swing.JMenu();
        mnuPermisos = new javax.swing.JMenuItem();
        mnuAyuda = new javax.swing.JMenu();
        mnuAcercaDe = new javax.swing.JMenuItem();

        setDefaultCloseOperation(javax.swing.WindowConstants.DO_NOTHING_ON_CLOSE);
        setTitle("SEM - Sistema de Gestión de Centros de Salud v1.0");
        addWindowListener(new java.awt.event.WindowAdapter() {
            public void windowClosing(java.awt.event.WindowEvent evt) {
                formWindowClosing(evt);
            }
        });

        mnuInicio.setText("Inicio");

        mnuAbrirHC.setText("Abrir HC");
        mnuInicio.add(mnuAbrirHC);

        mnuCita.setText("Cita");
        mnuInicio.add(mnuCita);

        mnuCambiarContrasena.setText("Cambiar Contraseña");
        mnuInicio.add(mnuCambiarContrasena);

        mnuCerrarSesion.setText("Cerrar Sesión");
        mnuInicio.add(mnuCerrarSesion);

        mbrPrincipal.add(mnuInicio);

        mnuPaciente.setText("Paciente");

        mnuTriage.setText("Triage");
        mnuPaciente.add(mnuTriage);

        mnuHC.setText("Historia Clínica");
        mnuPaciente.add(mnuHC);

        mnuHIS.setText("Formulario HIS");
        mnuPaciente.add(mnuHIS);

        mbrPrincipal.add(mnuPaciente);

        mnuPersonal.setText("Personal");

        mnuDoctor.setText("Doctor(a)");
        mnuDoctor.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                mnuDoctorActionPerformed(evt);
            }
        });
        mnuPersonal.add(mnuDoctor);

        mnuEnfermero.setText("Enfermero(a)");
        mnuEnfermero.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                mnuEnfermeroActionPerformed(evt);
            }
        });
        mnuPersonal.add(mnuEnfermero);

        mnuTecnico.setText("Técnico(a)");
        mnuTecnico.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                mnuTecnicoActionPerformed(evt);
            }
        });
        mnuPersonal.add(mnuTecnico);

        mbrPrincipal.add(mnuPersonal);

        mnuAdministracion.setText("Administración");

        mnuPermisos.setText("Permisos");
        mnuAdministracion.add(mnuPermisos);

        mbrPrincipal.add(mnuAdministracion);

        mnuAyuda.setText("Ayuda");

        mnuAcercaDe.setText("Acerca de");
        mnuAyuda.add(mnuAcercaDe);

        mbrPrincipal.add(mnuAyuda);

        setJMenuBar(mbrPrincipal);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 615, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 302, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void formWindowClosing(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowClosing
        this.dispose();
        this.ventanaBienvenida.reset();
        this.ventanaBienvenida.setVisible(true);
    }//GEN-LAST:event_formWindowClosing

    private void mnuDoctorActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_mnuDoctorActionPerformed
        frmDoctor ventanaDoctor = new frmDoctor(this, true);
        ventanaDoctor.setVisible(true);
    }//GEN-LAST:event_mnuDoctorActionPerformed

    private void mnuEnfermeroActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_mnuEnfermeroActionPerformed
        frmEnfermero ventanaEnfermero = new frmEnfermero(this, true);
        ventanaEnfermero.setVisible(true);
    }//GEN-LAST:event_mnuEnfermeroActionPerformed

    private void mnuTecnicoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_mnuTecnicoActionPerformed
        frmTecnico ventanaTecnico = new frmTecnico(this, true);
        ventanaTecnico.setVisible(true);
    }//GEN-LAST:event_mnuTecnicoActionPerformed

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JMenuBar mbrPrincipal;
    private javax.swing.JMenuItem mnuAbrirHC;
    private javax.swing.JMenuItem mnuAcercaDe;
    private javax.swing.JMenu mnuAdministracion;
    private javax.swing.JMenu mnuAyuda;
    private javax.swing.JMenuItem mnuCambiarContrasena;
    private javax.swing.JMenuItem mnuCerrarSesion;
    private javax.swing.JMenuItem mnuCita;
    private javax.swing.JMenuItem mnuDoctor;
    private javax.swing.JMenuItem mnuEnfermero;
    private javax.swing.JMenuItem mnuHC;
    private javax.swing.JMenuItem mnuHIS;
    private javax.swing.JMenu mnuInicio;
    private javax.swing.JMenu mnuPaciente;
    private javax.swing.JMenuItem mnuPermisos;
    private javax.swing.JMenu mnuPersonal;
    private javax.swing.JMenuItem mnuTecnico;
    private javax.swing.JMenuItem mnuTriage;
    // End of variables declaration//GEN-END:variables
}
