<%@page import="java.io.FileReader"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<%
	FileReader reader = null;
	String path = request.getParameter("path");
	reader = new FileReader(request.getServletContext().getRealPath(path));
%>
<pre>
	소스 코드 파일명 : <%=path %><br>
	<c:out value="${reader }" escapeXml="true"></c:out>
</pre>

<%
	if (reader != null)reader.close();
%>

</body>
</html>