<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>

<%
	String type = request.getParameter("type");
%><br>
<table width="100%" border="1" cellpadding="0" cellspacing="0">
	<tr>
		<td>타입</td>
		<td><%= type %></td>
	</tr>
	<tr>
		<td>특징</td>
		<td><%
			if (type.equals("iPhone"))
				out.println("어썸");
			else
				out.println("쏘쏘");
		%></td>
	</tr>
</table>

</body>
</html>