<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<!-- 주석에 대한 설명 -->

<!-- HTML 주석 -->

<%
	int result = 1;
	/* 1부터 10까지 곱하는 코드 (Java 주석)*/
	for (int i=1; i<=10; i++){
		result *= i;
	}
%>

<br>
1부터 10까지 곱하는 코드 <%-- <%= result %> (JSP 주석) --%>
</body>
</html>












