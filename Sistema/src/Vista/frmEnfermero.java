package Vista;

import javax.swing.JFrame;

public class frmEnfermero extends javax.swing.JDialog {

    public frmEnfermero(JFrame padre, boolean modal) {
        super(padre, modal);
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        tabEnfermero = new javax.swing.JTabbedPane();
        pnlBuscar = new javax.swing.JPanel();
        jScrollPane1 = new javax.swing.JScrollPane();
        dgvEnfermero = new javax.swing.JTable();
        pnlCriterios = new javax.swing.JPanel();
        lblPaterno = new javax.swing.JLabel();
        txtPaterno = new javax.swing.JTextField();
        lblMaterno = new javax.swing.JLabel();
        txtMaterno = new javax.swing.JTextField();
        lblNombres = new javax.swing.JLabel();
        txtNombres = new javax.swing.JTextField();
        lblEstado = new javax.swing.JLabel();
        cboEstado = new javax.swing.JComboBox();
        lblArea = new javax.swing.JLabel();
        cboArea = new javax.swing.JComboBox();
        btnVer = new javax.swing.JButton();
        btnNuevo = new javax.swing.JButton();
        btnModificar = new javax.swing.JButton();
        btnEliminar = new javax.swing.JButton();
        btnSalir = new javax.swing.JButton();
        pnlDetalle = new javax.swing.JPanel();
        lblFechaNacimiento = new javax.swing.JLabel();
        txtDNI = new javax.swing.JTextField();
        lblDNI = new javax.swing.JLabel();
        cboSexo = new javax.swing.JComboBox();
        lblEstadoCivil = new javax.swing.JLabel();
        calFechaNacimiento = new de.wannawork.jcalendar.JCalendarComboBox();
        lblSexo = new javax.swing.JLabel();
        txtDomicilio = new javax.swing.JTextField();
        lblDepartamento = new javax.swing.JLabel();
        cboEstadoCivil = new javax.swing.JComboBox();
        lblDomicilio = new javax.swing.JLabel();
        txtTelefono = new javax.swing.JTextField();
        lblTelefono = new javax.swing.JLabel();
        cboDistrito = new javax.swing.JComboBox();
        lblDistrito = new javax.swing.JLabel();
        cboProvincia = new javax.swing.JComboBox();
        lblPaternoDetalle = new javax.swing.JLabel();
        txtPaternoDetalle = new javax.swing.JTextField();
        lblMaternoDetalle = new javax.swing.JLabel();
        txtMaternoDetalle = new javax.swing.JTextField();
        cboDepartamento = new javax.swing.JComboBox();
        lblNombresDetalle = new javax.swing.JLabel();
        lblProvincia = new javax.swing.JLabel();
        txtNombresDetalle = new javax.swing.JTextField();
        lblEmail = new javax.swing.JLabel();
        txtEmail = new javax.swing.JTextField();
        lblAreaDetalle = new javax.swing.JLabel();
        cboAreaDetalle = new javax.swing.JComboBox();
        lblEstadoDetalle = new javax.swing.JLabel();
        cboEstadoDetalle = new javax.swing.JComboBox();
        btnCancelar = new javax.swing.JButton();
        btnGuardar = new javax.swing.JButton();
        lblNumeroLicenciatura = new javax.swing.JLabel();
        txtNumeroLicenciatura = new javax.swing.JTextField();

        setDefaultCloseOperation(javax.swing.WindowConstants.DO_NOTHING_ON_CLOSE);
        setTitle("Enfermero(a)");
        addWindowListener(new java.awt.event.WindowAdapter() {
            public void windowClosing(java.awt.event.WindowEvent evt) {
                formWindowClosing(evt);
            }
        });

        dgvEnfermero.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Ap. Paterno", "Ap. Materno", "Nombres", "Área"
            }
        ));
        jScrollPane1.setViewportView(dgvEnfermero);

        pnlCriterios.setBorder(javax.swing.BorderFactory.createTitledBorder("Criterios de Búsqueda"));

        lblPaterno.setText("Apellido Paterno:");

        lblMaterno.setText("Apellido Materno:");

        lblNombres.setText("Nombres:");

        lblEstado.setText("Estado:");

        cboEstado.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "ACTIVO", "INACTIVO", "TODOS" }));

        lblArea.setText("Área:");

        javax.swing.GroupLayout pnlCriteriosLayout = new javax.swing.GroupLayout(pnlCriterios);
        pnlCriterios.setLayout(pnlCriteriosLayout);
        pnlCriteriosLayout.setHorizontalGroup(
            pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlCriteriosLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                        .addComponent(txtNombres, javax.swing.GroupLayout.Alignment.LEADING)
                        .addComponent(lblPaterno, javax.swing.GroupLayout.Alignment.LEADING)
                        .addComponent(txtPaterno, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, 170, Short.MAX_VALUE))
                    .addComponent(lblNombres)
                    .addComponent(lblArea)
                    .addComponent(cboArea, javax.swing.GroupLayout.PREFERRED_SIZE, 115, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(lblEstado)
                    .addComponent(txtMaterno, javax.swing.GroupLayout.DEFAULT_SIZE, 170, Short.MAX_VALUE)
                    .addComponent(lblMaterno)
                    .addComponent(cboEstado, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(22, Short.MAX_VALUE))
        );
        pnlCriteriosLayout.setVerticalGroup(
            pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlCriteriosLayout.createSequentialGroup()
                .addGroup(pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblPaterno)
                    .addComponent(lblMaterno))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtPaterno, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtMaterno, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblNombres)
                    .addComponent(lblEstado))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlCriteriosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtNombres, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cboEstado, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(lblArea)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(cboArea, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(13, Short.MAX_VALUE))
        );

        btnVer.setText("Ver");

        btnNuevo.setText("Nuevo");

        btnModificar.setText("Modificar");

        btnEliminar.setText("Eliminar");

        btnSalir.setText("Salir");

        javax.swing.GroupLayout pnlBuscarLayout = new javax.swing.GroupLayout(pnlBuscar);
        pnlBuscar.setLayout(pnlBuscarLayout);
        pnlBuscarLayout.setHorizontalGroup(
            pnlBuscarLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlBuscarLayout.createSequentialGroup()
                .addGroup(pnlBuscarLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(pnlBuscarLayout.createSequentialGroup()
                        .addContainerGap()
                        .addGroup(pnlBuscarLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 399, Short.MAX_VALUE)
                            .addGroup(pnlBuscarLayout.createSequentialGroup()
                                .addComponent(btnVer, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(btnNuevo, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(btnModificar, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(btnEliminar, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(btnSalir, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE))))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnlBuscarLayout.createSequentialGroup()
                        .addGap(7, 7, 7)
                        .addComponent(pnlCriterios, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
                .addContainerGap())
        );
        pnlBuscarLayout.setVerticalGroup(
            pnlBuscarLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlBuscarLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(pnlCriterios, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 161, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(pnlBuscarLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnVer)
                    .addComponent(btnNuevo)
                    .addComponent(btnModificar)
                    .addComponent(btnEliminar)
                    .addComponent(btnSalir))
                .addContainerGap(17, Short.MAX_VALUE))
        );

        tabEnfermero.addTab("Buscar", pnlBuscar);

        lblFechaNacimiento.setText("Fecha Nacimiento:");

        lblDNI.setText("DNI:");

        cboSexo.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "M", "F" }));

        lblEstadoCivil.setText("Estado Civil:");

        lblSexo.setText("Sexo:");

        txtDomicilio.setToolTipText("");

        lblDepartamento.setText("Departamento:");

        cboEstadoCivil.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "SOLTERO", "CASADO", "VIUDO", "DIVORCIADO", "OTRO" }));

        lblDomicilio.setText("Domicilio:");

        lblTelefono.setText("Teléfono:");

        lblDistrito.setText("Distrito:");

        lblPaternoDetalle.setText("Apellido Paterno:");

        lblMaternoDetalle.setText("Apellido Materno:");

        lblNombresDetalle.setText("Nombres:");

        lblProvincia.setText("Provincia:");

        lblEmail.setText("Email:");

        lblAreaDetalle.setText("Área:");

        lblEstadoDetalle.setText("Estado:");

        cboEstadoDetalle.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "ACTIVO", "INACTIVO" }));

        btnCancelar.setText("Cancelar");
        btnCancelar.setVerticalAlignment(javax.swing.SwingConstants.BOTTOM);

        btnGuardar.setText("Guardar");
        btnGuardar.setVerticalAlignment(javax.swing.SwingConstants.BOTTOM);

        lblNumeroLicenciatura.setText("No. Licenciatura:");

        javax.swing.GroupLayout pnlDetalleLayout = new javax.swing.GroupLayout(pnlDetalle);
        pnlDetalle.setLayout(pnlDetalleLayout);
        pnlDetalleLayout.setHorizontalGroup(
            pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlDetalleLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(lblNombresDetalle)
                    .addGroup(pnlDetalleLayout.createSequentialGroup()
                        .addComponent(lblPaternoDetalle)
                        .addGap(118, 118, 118)
                        .addComponent(lblMaternoDetalle))
                    .addGroup(pnlDetalleLayout.createSequentialGroup()
                        .addComponent(txtPaternoDetalle, javax.swing.GroupLayout.PREFERRED_SIZE, 182, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(txtMaternoDetalle, javax.swing.GroupLayout.PREFERRED_SIZE, 182, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(lblDomicilio)
                    .addGroup(pnlDetalleLayout.createSequentialGroup()
                        .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                            .addComponent(txtNombresDetalle, javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(javax.swing.GroupLayout.Alignment.LEADING, pnlDetalleLayout.createSequentialGroup()
                                .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(pnlDetalleLayout.createSequentialGroup()
                                        .addComponent(lblDNI)
                                        .addGap(58, 58, 58)
                                        .addComponent(lblFechaNacimiento))
                                    .addGroup(pnlDetalleLayout.createSequentialGroup()
                                        .addComponent(txtDNI, javax.swing.GroupLayout.PREFERRED_SIZE, 70, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGap(10, 10, 10)
                                        .addComponent(calFechaNacimiento, javax.swing.GroupLayout.PREFERRED_SIZE, 110, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(pnlDetalleLayout.createSequentialGroup()
                                        .addGap(19, 19, 19)
                                        .addComponent(lblSexo))
                                    .addGroup(pnlDetalleLayout.createSequentialGroup()
                                        .addGap(18, 18, 18)
                                        .addComponent(cboSexo, javax.swing.GroupLayout.PREFERRED_SIZE, 60, javax.swing.GroupLayout.PREFERRED_SIZE)))))
                        .addGap(18, 18, 18)
                        .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(cboEstadoCivil, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(lblEstadoCivil))
                        .addGap(15, 15, 15))
                    .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                        .addGroup(pnlDetalleLayout.createSequentialGroup()
                            .addComponent(btnCancelar, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGap(18, 18, 18)
                            .addComponent(btnGuardar, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addComponent(txtDomicilio, javax.swing.GroupLayout.PREFERRED_SIZE, 380, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnlDetalleLayout.createSequentialGroup()
                        .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(pnlDetalleLayout.createSequentialGroup()
                                .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                                        .addComponent(cboAreaDetalle, javax.swing.GroupLayout.Alignment.LEADING, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                        .addComponent(txtTelefono, javax.swing.GroupLayout.Alignment.LEADING)
                                        .addComponent(cboDepartamento, javax.swing.GroupLayout.Alignment.LEADING, 0, 120, Short.MAX_VALUE)
                                        .addComponent(lblTelefono, javax.swing.GroupLayout.Alignment.LEADING))
                                    .addComponent(lblAreaDetalle))
                                .addGap(10, 10, 10)
                                .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(cboProvincia, 0, 135, Short.MAX_VALUE)
                                    .addComponent(lblEmail)
                                    .addComponent(txtEmail, javax.swing.GroupLayout.DEFAULT_SIZE, 135, Short.MAX_VALUE))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED))
                            .addGroup(pnlDetalleLayout.createSequentialGroup()
                                .addComponent(lblDepartamento)
                                .addGap(57, 57, 57)
                                .addComponent(lblProvincia)
                                .addGap(94, 94, 94)))
                        .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(lblDistrito)
                            .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                .addComponent(lblNumeroLicenciatura)
                                .addComponent(lblEstadoDetalle)
                                .addComponent(cboEstadoDetalle, 0, 109, Short.MAX_VALUE)
                                .addComponent(cboDistrito, 0, 109, Short.MAX_VALUE)
                                .addComponent(txtNumeroLicenciatura)))
                        .addGap(11, 11, 11)))
                .addGap(15, 15, 15))
        );
        pnlDetalleLayout.setVerticalGroup(
            pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlDetalleLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(lblPaternoDetalle)
                    .addComponent(lblMaternoDetalle))
                .addGap(1, 1, 1)
                .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(txtPaternoDetalle, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtMaternoDetalle, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(lblNombresDetalle)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtNombresDetalle, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(lblDNI)
                    .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(lblFechaNacimiento)
                        .addComponent(lblSexo)
                        .addComponent(lblEstadoCivil)))
                .addGap(6, 6, 6)
                .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(txtDNI, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(cboSexo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(cboEstadoCivil, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(calFechaNacimiento, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(lblDomicilio)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtDomicilio, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(10, 10, 10)
                .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(lblDepartamento)
                    .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(lblProvincia)
                        .addComponent(lblDistrito)))
                .addGap(6, 6, 6)
                .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(cboProvincia, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cboDepartamento, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cboDistrito, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblTelefono)
                    .addComponent(lblEmail)
                    .addComponent(lblNumeroLicenciatura))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtTelefono, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtEmail, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtNumeroLicenciatura, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblAreaDetalle)
                    .addComponent(lblEstadoDetalle))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(cboAreaDetalle, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cboEstadoDetalle, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(pnlDetalleLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnGuardar, javax.swing.GroupLayout.DEFAULT_SIZE, 55, Short.MAX_VALUE)
                    .addComponent(btnCancelar, javax.swing.GroupLayout.DEFAULT_SIZE, 55, Short.MAX_VALUE))
                .addContainerGap())
        );

        tabEnfermero.addTab("Detalle", pnlDetalle);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(tabEnfermero, javax.swing.GroupLayout.PREFERRED_SIZE, 421, javax.swing.GroupLayout.PREFERRED_SIZE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(tabEnfermero, javax.swing.GroupLayout.PREFERRED_SIZE, 451, javax.swing.GroupLayout.PREFERRED_SIZE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void formWindowClosing(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowClosing
        this.dispose();
    }//GEN-LAST:event_formWindowClosing

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnCancelar;
    private javax.swing.JButton btnEliminar;
    private javax.swing.JButton btnGuardar;
    private javax.swing.JButton btnModificar;
    private javax.swing.JButton btnNuevo;
    private javax.swing.JButton btnSalir;
    private javax.swing.JButton btnVer;
    private de.wannawork.jcalendar.JCalendarComboBox calFechaNacimiento;
    private javax.swing.JComboBox cboArea;
    private javax.swing.JComboBox cboAreaDetalle;
    private javax.swing.JComboBox cboDepartamento;
    private javax.swing.JComboBox cboDistrito;
    private javax.swing.JComboBox cboEstado;
    private javax.swing.JComboBox cboEstadoCivil;
    private javax.swing.JComboBox cboEstadoDetalle;
    private javax.swing.JComboBox cboProvincia;
    private javax.swing.JComboBox cboSexo;
    private javax.swing.JTable dgvEnfermero;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JLabel lblArea;
    private javax.swing.JLabel lblAreaDetalle;
    private javax.swing.JLabel lblDNI;
    private javax.swing.JLabel lblDepartamento;
    private javax.swing.JLabel lblDistrito;
    private javax.swing.JLabel lblDomicilio;
    private javax.swing.JLabel lblEmail;
    private javax.swing.JLabel lblEstado;
    private javax.swing.JLabel lblEstadoCivil;
    private javax.swing.JLabel lblEstadoDetalle;
    private javax.swing.JLabel lblFechaNacimiento;
    private javax.swing.JLabel lblMaterno;
    private javax.swing.JLabel lblMaternoDetalle;
    private javax.swing.JLabel lblNombres;
    private javax.swing.JLabel lblNombresDetalle;
    private javax.swing.JLabel lblNumeroLicenciatura;
    private javax.swing.JLabel lblPaterno;
    private javax.swing.JLabel lblPaternoDetalle;
    private javax.swing.JLabel lblProvincia;
    private javax.swing.JLabel lblSexo;
    private javax.swing.JLabel lblTelefono;
    private javax.swing.JPanel pnlBuscar;
    private javax.swing.JPanel pnlCriterios;
    private javax.swing.JPanel pnlDetalle;
    private javax.swing.JTabbedPane tabEnfermero;
    private javax.swing.JTextField txtDNI;
    private javax.swing.JTextField txtDomicilio;
    private javax.swing.JTextField txtEmail;
    private javax.swing.JTextField txtMaterno;
    private javax.swing.JTextField txtMaternoDetalle;
    private javax.swing.JTextField txtNombres;
    private javax.swing.JTextField txtNombresDetalle;
    private javax.swing.JTextField txtNumeroLicenciatura;
    private javax.swing.JTextField txtPaterno;
    private javax.swing.JTextField txtPaternoDetalle;
    private javax.swing.JTextField txtTelefono;
    // End of variables declaration//GEN-END:variables
}
