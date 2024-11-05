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
public int add(int a, int b){
	return a+b;
}
public int min(int a, int b){
	return a-b;
}
public int mul(int a, int b){
	return a*b;
}
public int div(int a, int b){
	return a/b;
}
%>
<%
	int num1 = Integer.parseInt(request.getParameter("num1"));
	int num2 = Integer.parseInt(request.getParameter("num2"));

%>

<h3>사칙연산 결과</h3>
<%=num1 %> + <%=num2 %> = <%=add(num1,num2) %>  <br>
<%=num1 %> - <%=num2 %> = <%=min(num1,num2) %>  <br>
<%=num1 %> * <%=num2 %> = <%=mul(num1,num2) %>  <br>
<%=num1 %> / <%=num2 %> = <%=div(num1,num2) %>  <br>
</body>
</html>