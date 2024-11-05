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
 public int Sum(int a, int b){
	return a + b;
} 
%>
<%


	int total = 0;
	for (int i=1; i<=100; i++){
		total += i;
	}
%>
	1~100 = <%=total %>
	sum(10, 15) = <%=Sum(10, 15) %>
</body>
</html>