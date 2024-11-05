<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<table width="100%" border="1">
		<tr><td>model num</td><td>ASDASDQWE</td></tr>
		<tr><td>price</td><td>1,111,111</td></tr>
	</table>
	<jsp:include page="infoSub.jsp">
		<jsp:param name="type" value="iPhone"/>
	</jsp:include>
</body>
</html>