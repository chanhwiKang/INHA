<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<%!
	public int multi(int a, int b){
		return a*b;
	}
%>
	33*44 = <%=multi(33,44) %>
</body>
</html>