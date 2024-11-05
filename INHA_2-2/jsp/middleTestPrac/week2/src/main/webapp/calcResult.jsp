<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<jsp:useBean id="calc" class="week2.Calculator"/>
<jsp:setProperty property="*" name="calc"/>

<h1>계산기</h1>
<hr>
답: <%=calc.Calc() %>
</body>
</html>