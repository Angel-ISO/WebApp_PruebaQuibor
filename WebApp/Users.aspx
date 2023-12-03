<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="WebApp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Registro Empleados</h1>

 <asp:Label runat="server" ID="lbl_mensaje"></asp:Label>

    <div>
        <label for="txtNombres">Nombres:</label>
        <asp:TextBox ID="txtNombres" runat="server" OnTextChanged="txtNombres_TextChanged" CssClass="form-control" placeholder="inserte su nombre"></asp:TextBox>
    </div>
    
    <div>
        <label for="txtApellidos">Apellidos:</label>
        <asp:TextBox ID="txtApellidos" runat="server" CssClass="form-control" placeholder="inserte su apellido"></asp:TextBox>
    </div>
    
    <div>
        <label for="txtTelefono">Teléfono:</label>
        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" placeholder="inserte su telefono"></asp:TextBox>
    </div>
    
    <div>
        <label for="txtCiudad">Ciudad:</label>
        <asp:TextBox ID="txtCiudad" runat="server" CssClass="form-control" placeholder="inserte ciudad donde reside"></asp:TextBox>
    </div>
    
   
    
    <div>
        <label for="txtVentaMes">VentaMes:</label>
        <asp:TextBox ID="txtVentaMes" runat="server" CssClass="form-control" placeholder="total vendido en el mes"></asp:TextBox>
    </div>

     <div>
     <label for="ddlMes">Mes:</label>
     <asp:DropDownList ID="ddlMes" runat="server"  CssClass="form-control">
         <asp:ListItem Text="Enero" Value="1"></asp:ListItem>
         <asp:ListItem Text="Febrero" Value="2"></asp:ListItem>
         <asp:ListItem Text="Marzo" Value="3"></asp:ListItem>
         <asp:ListItem Text="Abril" Value="4"></asp:ListItem>
         <asp:ListItem Text="Mayo" Value="5"></asp:ListItem>
         <asp:ListItem Text="Junio" Value="6"></asp:ListItem>
         <asp:ListItem Text="Julio" Value="7"></asp:ListItem>
         <asp:ListItem Text="Agosto" Value="8"></asp:ListItem>
         <asp:ListItem Text="Septiembre" Value="9"></asp:ListItem>
         <asp:ListItem Text="Octubre" Value="10"></asp:ListItem>
         <asp:ListItem Text="Noviembre" Value="11"></asp:ListItem>
         <asp:ListItem Text="Diciembre" Value="12"></asp:ListItem>
     </asp:DropDownList>
 </div>
    <br />


    <asp:Button ID="Btn_guardar" runat="server" Text="Guardar Valores" CssClass="btn btn-success" OnClick="BtnGuardar_Click" />
    <asp:Button ID="Btn_actualizar" runat="server" Text="Actualizar valores Valores" CssClass="btn btn-warning" OnClick="Btn_actualizar_Click" />

    
    <asp:GridView ID="grid_usuarios" runat="server" AutoGenerateColumns="False" CssClass="table" DataKeyNames="UserId" OnRowDeleting="grid_usuarios_RowDeleting" OnSelectedIndexChanged="grid_usuarios_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="UserId" HeaderText="idUsuario" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombres" />
            <asp:BoundField DataField="apellido" HeaderText="Apellidos" />
            <asp:BoundField DataField="telefono" HeaderText="Telefono" />
            <asp:BoundField DataField="ciudad" HeaderText="Ciudad" />
            <asp:BoundField DataField="mes" HeaderText="Mes" />
            <asp:BoundField DataField="ventames" HeaderText="VentaMes" DataFormatString="{0:c}" />
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="btn_select" runat="server" CausesValidation="False" CommandName="Select" Text="ver" CssClass="btn btn-info" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="btn_borrar" runat="server" CausesValidation="False" CommandName="Delete" Text="borrar" CssClass="btn btn-danger" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
