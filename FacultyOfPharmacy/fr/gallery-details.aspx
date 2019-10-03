<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gallery-details.aspx.cs" Inherits="FacultyOfPharmacy.fr.gallery_details" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <script src="//code.jquery.com/jquery-2.1.3.min.js"></script>
    <link rel="stylesheet" type="text/css" title="Dynamic Style Sheet" href="../css/spotlight.css" />

    <script src="../js/spotlight.js"></script>
</head>
<body>
    <div id="spotlight-d57ad676-ea61-41fe-a0b9-9d338be58371" class="spotlight-main carousel slide">
        <%--<ol class="carousel-indicators">
            <%for(int i=0;i<images.Count; i++){ %>
            <li class="active" data-target="#spotlight-d57ad676-ea61-41fe-a0b9-9d338be58371" data-slide-to="<%=i %>"></li>
            <%} %>
        </ol>--%>
        <div class="carousel-inner">
            <%for(int i=0;i<images.Count;i++){ %>
            <div class="item <%=i==0?"active":"" %>" data-index="<%=i %>">
                <a>
                    <img src="../Media/<%=images[i].img %>" style="height:400px;width:auto"/><%--<div class="carousel-caption">
                        <p><%=result.description %></p>
                    </div>--%>
                </a>
            </div>
            <%} %>
            
        </div>
        <a class="left carousel-control" data-slide="prev" href=".spotlight-main"><span class="glyphicon glyphicon-chevron-left"></span></a><a class="right carousel-control" data-slide="next" href=".spotlight-main"><span class="glyphicon glyphicon-chevron-right"></span></a>
    </div>
    </div>
								</div>
							</div>
    <div class="button-head">
    <div onclick="$('#searchTool').slideToggle()" style="font-size:15px;height:40px;line-height:40px;cursor:pointer">INFO</div>
    <div id="searchTool" style="height: auto; padding: 10px; display: none;">
        <p style="font-weight:normal;font-size:12px;text-align:justify"><%=result.description %></p>
    </div>
</div>
    <style>
        .button-head{
            position:fixed;
            top:0px;
            right:70px;
            z-index:99999999999;
            height:auto;
            width:200px;
            background-color:rgba(0,0,0,0.5);
            color:white;
            text-align:center
        }
        @media(max-width:600px)
        {
            .button-head {
                max-height:180px;
                width:150px !important;
            }
            .button-head p{
                height:130px;
                overflow:auto;
                display:block;
            }
        }
    </style>
</body>
</html>

