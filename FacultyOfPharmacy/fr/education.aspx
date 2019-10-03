<%@ Page Title="" Language="C#" MasterPageFile="~/fr/fr.master" AutoEventWireup="true" CodeBehind="education.aspx.cs" Inherits="FacultyOfPharmacy.fr.education" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    
    <!--content-->
    
        <div class="container">
					<h2 class="marTop4">Cursus</h2>
            <div class="row">
                <div class="grid_12">
                    <h4 style="text-transform:initial;" id="descriTitle" runat="server">La faculté de pharmacie est une faculté innovante et moderne, qui propose cinq années d’études<br /> de base et plusieurs types de masters en sciences pharmaceutiques, de la façon suivante:</h4>
                    <ul class="list1-1" id="descriDesc" runat="server">
                        <li>Cursus des études de Pharmacie (Equivalent Master 1 ; 5ans) (Options : générale, pharmacie clinique, officine, pharmacie hospitalière, recherche clinique, pharmacie industrielle, management)</li>
                        <li>Cursus PharmD (1 an ; Facultatif ; Options : clinique, officine, pharmacie hospitalière)</li>
<li>Cursus Master 2 de Recherche en Pharmacie Clinique et Pharmaco épidémiologie (1 an ; facultatif)</li>
<li>Cursus Master 2 Professionnel en Pharmacie Clinique (1 an ; facultatif)</li>
<li>Cursus Professional Master 2 Pharmaceutical Industry (1 an; facultatif)</li>
<li>Cursus Proposé Professional Pharmaceutical Master 2 Business Administration (PMBA) (1 an; facultative).</li>
<li>Cursus Master 2 de Recherche en Pharmacologie et Toxicologie</li>
<li>cursus Master 2 de Recherche en Biotechnologie Pharmaceutique</li>
                        
                        </ul>
                       <form id="Form1" runat="server"> 
                    <h4>
                        Specialitée - Semestre:&nbsp;<asp:DropDownList ID="searchDropDown" runat="server" style="padding:7px;width:400px" AutoPostBack="true" OnSelectedIndexChanged="searchDropDown_SelectedIndexChanged" />
                    </h4>
                    <p>
                    
<asp:GridView ID="grid" runat="server" AutoGenerateColumns="false" Width="100%" 
        HorizontalAlign="Center" PageSize="9" AllowPaging="true" 
        onpageindexchanged="grid_PageIndexChanged" 
        onpageindexchanging="grid_PageIndexChanging" CssClass="educationGrid">
<Columns>
    <asp:BoundField HeaderText="Matière" DataField="title" SortExpression="title" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="30" ItemStyle-Wrap="true"/>
<asp:BoundField HeaderText="Credits" DataField="credits" SortExpression="credits" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="30"/>
<asp:TemplateField HeaderText="Contenu" SortExpression="description" ItemStyle-HorizontalAlign="Left">
    <ItemTemplate>
         <asp:Label ID="Label1" runat="server" Text='<%# Bind("description") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>
</Columns>
</asp:GridView>
</p></form></div>
                </div>
            </div>
</asp:Content>
