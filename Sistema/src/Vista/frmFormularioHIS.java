package Vista;

public class frmFormularioHIS extends javax.swing.JFrame {

    public frmFormularioHIS() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        rbtngEstablecimiento = new javax.swing.ButtonGroup();
        rbtngServicio = new javax.swing.ButtonGroup();
        lblFecha = new javax.swing.JLabel();
        txtFecha = new javax.swing.JTextField();
        lblHistoriaClinica = new javax.swing.JLabel();
        txtHistoriaClinica = new javax.swing.JTextField();
        lblDepartamento = new javax.swing.JLabel();
        lblProvincia = new javax.swing.JLabel();
        lblDistrito = new javax.swing.JLabel();
        cboDepartamento = new javax.swing.JComboBox();
        cboProvincia = new javax.swing.JComboBox();
        cboDistrito = new javax.swing.JComboBox();
        lblEdad = new javax.swing.JLabel();
        txtEdad = new javax.swing.JTextField();
        lblSexo = new javax.swing.JLabel();
        cboSexo = new javax.swing.JComboBox();
        pnlEstablecimiento = new javax.swing.JPanel();
        rbtnEstablecimientoN = new javax.swing.JRadioButton();
        rbtnEstablecimientoC = new javax.swing.JRadioButton();
        rbtnEstablecimientoR = new javax.swing.JRadioButton();
        pnlServicio = new javax.swing.JPanel();
        rbtnServicioN = new javax.swing.JRadioButton();
        rbtnServicioC = new javax.swing.JRadioButton();
        rbtnServicioR = new javax.swing.JRadioButton();
        pnlDiagnóstico = new javax.swing.JPanel();
        jScrollPane1 = new javax.swing.JScrollPane();
        lstDiagnostico = new javax.swing.JList();
        btnCIE10 = new javax.swing.JButton();
        btnCancelar = new javax.swing.JButton();
        btnGuardar = new javax.swing.JButton();
        pnlTipoDiagnostico = new javax.swing.JPanel();
        rbtnDiagnosticoP = new javax.swing.JRadioButton();
        rbtnDiagnosticoD = new javax.swing.JRadioButton();
        rbtnServicioDiagnosticoR = new javax.swing.JRadioButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.DO_NOTHING_ON_CLOSE);
        setTitle("Formulario HIS");

        lblFecha.setText("Fecha:");

        txtFecha.setEditable(false);

        lblHistoriaClinica.setText("No. Historia Clínica:");

        lblDepartamento.setText("Departamento:");

        lblProvincia.setText("Provincia:");

        lblDistrito.setText("Distrito:");

        cboDistrito.setMinimumSize(new java.awt.Dimension(28, 20));

        lblEdad.setText("Edad:");

        lblSexo.setText("Sexo:");

        cboSexo.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Masculino", "Femenino" }));

        pnlEstablecimiento.setBorder(javax.swing.BorderFactory.createTitledBorder("Establecimiento"));

        rbtnEstablecimientoN.setText("N");

        rbtnEstablecimientoC.setText("C");

        rbtnEstablecimientoR.setText("R");

        javax.swing.GroupLayout pnlEstablecimientoLayout = new javax.swing.GroupLayout(pnlEstablecimiento);
        pnlEstablecimiento.setLayout(pnlEstablecimientoLayout);
        pnlEstablecimientoLayout.setHorizontalGroup(
            pnlEstablecimientoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlEstablecimientoLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlEstablecimientoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(rbtnEstablecimientoN)
                    .addComponent(rbtnEstablecimientoC)
                    .addComponent(rbtnEstablecimientoR))
                .addContainerGap(76, Short.MAX_VALUE))
        );
        pnlEstablecimientoLayout.setVerticalGroup(
            pnlEstablecimientoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlEstablecimientoLayout.createSequentialGroup()
                .addComponent(rbtnEstablecimientoN)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(rbtnEstablecimientoC)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(rbtnEstablecimientoR)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pnlServicio.setBorder(javax.swing.BorderFactory.createTitledBorder("Servicio"));

        rbtnServicioN.setText("N");

        rbtnServicioC.setText("C");

        rbtnServicioR.setText("R");

        javax.swing.GroupLayout pnlServicioLayout = new javax.swing.GroupLayout(pnlServicio);
        pnlServicio.setLayout(pnlServicioLayout);
        pnlServicioLayout.setHorizontalGroup(
            pnlServicioLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 114, Short.MAX_VALUE)
            .addGroup(pnlServicioLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlServicioLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(rbtnServicioN)
                    .addComponent(rbtnServicioC)
                    .addComponent(rbtnServicioR))
                .addContainerGap(75, Short.MAX_VALUE))
        );
        pnlServicioLayout.setVerticalGroup(
            pnlServicioLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 82, Short.MAX_VALUE)
            .addGroup(pnlServicioLayout.createSequentialGroup()
                .addComponent(rbtnServicioN)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(rbtnServicioC)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(rbtnServicioR)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pnlDiagnóstico.setBorder(javax.swing.BorderFactory.createTitledBorder("Diagnóstico"));

        jScrollPane1.setViewportView(lstDiagnostico);

        btnCIE10.setText("CIE-10");

        javax.swing.GroupLayout pnlDiagnósticoLayout = new javax.swing.GroupLayout(pnlDiagnóstico);
        pnlDiagnóstico.setLayout(pnlDiagnósticoLayout);
        pnlDiagnósticoLayout.setHorizontalGroup(
            pnlDiagnósticoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlDiagnósticoLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 317, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(btnCIE10, javax.swing.GroupLayout.DEFAULT_SIZE, 93, Short.MAX_VALUE)
                .addContainerGap())
        );
        pnlDiagnósticoLayout.setVerticalGroup(
            pnlDiagnósticoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlDiagnósticoLayout.createSequentialGroup()
                .addGroup(pnlDiagnósticoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 96, Short.MAX_VALUE)
                    .addComponent(btnCIE10))
                .addContainerGap())
        );

        btnCancelar.setText("Cancelar");
        btnCancelar.setVerticalAlignment(javax.swing.SwingConstants.BOTTOM);

        btnGuardar.setText("Guardar");
        btnGuardar.setVerticalAlignment(javax.swing.SwingConstants.BOTTOM);

        pnlTipoDiagnostico.setBorder(javax.swing.BorderFactory.createTitledBorder("Tipo de Diagnóstico"));

        rbtnDiagnosticoP.setText("P");

        rbtnDiagnosticoD.setText("D");

        rbtnServicioDiagnosticoR.setText("R");

        javax.swing.GroupLayout pnlTipoDiagnosticoLayout = new javax.swing.GroupLayout(pnlTipoDiagnostico);
        pnlTipoDiagnostico.setLayout(pnlTipoDiagnosticoLayout);
        pnlTipoDiagnosticoLayout.setHorizontalGroup(
            pnlTipoDiagnosticoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 114, Short.MAX_VALUE)
            .addGap(0, 114, Short.MAX_VALUE)
            .addGroup(pnlTipoDiagnosticoLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlTipoDiagnosticoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(rbtnDiagnosticoP)
                    .addComponent(rbtnDiagnosticoD)
                    .addComponent(rbtnServicioDiagnosticoR))
                .addContainerGap(75, Short.MAX_VALUE))
        );
        pnlTipoDiagnosticoLayout.setVerticalGroup(
            pnlTipoDiagnosticoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 82, Short.MAX_VALUE)
            .addGap(0, 82, Short.MAX_VALUE)
            .addGroup(pnlTipoDiagnosticoLayout.createSequentialGroup()
                .addComponent(rbtnDiagnosticoP)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(rbtnDiagnosticoD)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(rbtnServicioDiagnosticoR)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(pnlDiagnóstico, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(pnlEstablecimiento, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(lblEdad)
                            .addComponent(cboDepartamento, 0, 127, Short.MAX_VALUE)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(lblFecha)
                                .addGap(18, 18, 18)
                                .addComponent(txtFecha, javax.swing.GroupLayout.PREFERRED_SIZE, 76, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addComponent(lblDepartamento)
                            .addComponent(txtEdad, javax.swing.GroupLayout.PREFERRED_SIZE, 78, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(35, 35, 35)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(lblHistoriaClinica)
                                .addGap(18, 18, 18)
                                .addComponent(txtHistoriaClinica, javax.swing.GroupLayout.PREFERRED_SIZE, 88, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(pnlServicio, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                                        .addComponent(lblProvincia, javax.swing.GroupLayout.Alignment.LEADING)
                                        .addComponent(cboProvincia, javax.swing.GroupLayout.Alignment.LEADING, 0, 126, Short.MAX_VALUE)
                                        .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                            .addGap(1, 1, 1)
                                            .addComponent(lblSexo)))
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(cboSexo, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 51, Short.MAX_VALUE)))
                                .addGap(38, 38, 38)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(pnlTipoDiagnostico, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                        .addComponent(lblDistrito)
                                        .addComponent(cboDistrito, 0, 126, Short.MAX_VALUE))))))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(btnCancelar, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(btnGuardar, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblFecha)
                    .addComponent(txtFecha, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lblHistoriaClinica)
                    .addComponent(txtHistoriaClinica, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblDepartamento)
                    .addComponent(lblProvincia)
                    .addComponent(lblDistrito))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(cboDepartamento, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cboProvincia, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cboDistrito, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(lblEdad)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(txtEdad, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(lblSexo)
                        .addGap(6, 6, 6)
                        .addComponent(cboSexo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(pnlTipoDiagnostico, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pnlServicio, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pnlEstablecimiento, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(pnlDiagnóstico, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnGuardar, javax.swing.GroupLayout.PREFERRED_SIZE, 55, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnCancelar, javax.swing.GroupLayout.PREFERRED_SIZE, 55, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnCIE10;
    private javax.swing.JButton btnCancelar;
    private javax.swing.JButton btnGuardar;
    private javax.swing.JComboBox cboDepartamento;
    private javax.swing.JComboBox cboDistrito;
    private javax.swing.JComboBox cboProvincia;
    private javax.swing.JComboBox cboSexo;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JLabel lblDepartamento;
    private javax.swing.JLabel lblDistrito;
    private javax.swing.JLabel lblEdad;
    private javax.swing.JLabel lblFecha;
    private javax.swing.JLabel lblHistoriaClinica;
    private javax.swing.JLabel lblProvincia;
    private javax.swing.JLabel lblSexo;
    private javax.swing.JList lstDiagnostico;
    private javax.swing.JPanel pnlDiagnóstico;
    private javax.swing.JPanel pnlEstablecimiento;
    private javax.swing.JPanel pnlServicio;
    private javax.swing.JPanel pnlTipoDiagnostico;
    private javax.swing.JRadioButton rbtnDiagnosticoD;
    private javax.swing.JRadioButton rbtnDiagnosticoP;
    private javax.swing.JRadioButton rbtnEstablecimientoC;
    private javax.swing.JRadioButton rbtnEstablecimientoN;
    private javax.swing.JRadioButton rbtnEstablecimientoR;
    private javax.swing.JRadioButton rbtnServicioC;
    private javax.swing.JRadioButton rbtnServicioDiagnosticoR;
    private javax.swing.JRadioButton rbtnServicioN;
    private javax.swing.JRadioButton rbtnServicioR;
    private javax.swing.ButtonGroup rbtngEstablecimiento;
    private javax.swing.ButtonGroup rbtngServicio;
    private javax.swing.JTextField txtEdad;
    private javax.swing.JTextField txtFecha;
    private javax.swing.JTextField txtHistoriaClinica;
    // End of variables declaration//GEN-END:variables
}
