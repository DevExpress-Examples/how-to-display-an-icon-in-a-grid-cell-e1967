<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="ImageColumn._Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxGridView.v9.3, Version=9.3.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>

<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.3, Version=9.3.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>GridViewDataImageColumn example</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dxwgv:ASPxGridView ID="ASPxGridView1" runat="server" 
			AutoGenerateColumns="False" KeyFieldName="ID" ClientInstanceName="grid">
			<Columns>
				<dxwgv:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0">
				</dxwgv:GridViewCommandColumn>
				<dxwgv:GridViewDataTextColumn FieldName="ID" VisibleIndex="1">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataTextColumn FieldName="Value" VisibleIndex="2">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataColumn Caption="Image (Template)" VisibleIndex="3">
					<DataItemTemplate>
						<img runat="server" src='<%#GetImageName(Eval("Value"))%>' />
					</DataItemTemplate>
				</dxwgv:GridViewDataColumn>
			</Columns>
		</dxwgv:ASPxGridView>
		<dxe:ASPxButton ID="ASPxButton1" runat="server" AutoPostBack="False" 
			Text="Select All">
			<ClientSideEvents Click="function(s, e) {
	grid.SelectAllRowsOnPage();
}" />
		</dxe:ASPxButton>
	</div>
	</form>
</body>
</html>