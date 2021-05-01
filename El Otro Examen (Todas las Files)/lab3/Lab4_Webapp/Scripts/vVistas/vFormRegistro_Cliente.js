
function vFormRegistro_Cliente() {

	// CAMBIAR ESTO A CLIENTE
	this.tblUsuariosId = 'tblClientes';
	// Ver esto
	this.service = 'cliente';
	this.ctrlActions = new ControlActions();

	// CAMBIAR ESTO A CLIENTE
	this.columns = "cedula, nombre, apellido, fecha_nacimiento, edad, estado_civil, genero";

	this.RetrieveAll = function () {
		this.ctrlActions.FillTable(this.service, this.tblUsuariosId, false); 		
	}

	this.ReloadTable = function () {
		this.ctrlActions.FillTable(this.service, this.tblUsuariosId, true);
	}

	this.Create = function () {
		var usuarioData = {};
		usuarioData = this.ctrlActions.GetDataForm('frmEdition');
		//Hace el post al create
		this.ctrlActions.PostToAPI(this.service, usuarioData);
		//Refresca la tabla
		this.ReloadTable();
	}

	this.Update = function () {

		var usuarioData = {};
		usuarioData = this.ctrlActions.GetDataForm('frmEdition');
		//Hace el post al create
		this.ctrlActions.PutToAPI(this.service, usuarioData);
		//Refresca la tabla
		this.ReloadTable();

	}

	this.Delete = function () {

		var usuarioData = {};
		usuarioData = this.ctrlActions.GetDataForm('frmEdition');
		//Hace el post al create
		this.ctrlActions.DeleteToAPI(this.service, usuarioData);
		//Refresca la tabla
		this.ReloadTable();

	}

	this.BindFields = function (data) {
		this.ctrlActions.BindFields('frmEdition', data);
	}
}

//ON DOCUMENT READY
$(document).ready(function () {	
	var vCliente = new vFormRegistro_Cliente();
	vCliente.RetrieveAll();

});

