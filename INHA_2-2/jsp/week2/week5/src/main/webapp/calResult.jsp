<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<h1>계산 결과</h1>
<jsp:useBean id="calc" class="week5.Calculator" />
<jsp:setProperty property="*" name="calc"/>

<h3>
<%= calc.getNum1() %>
<%= calc.getOp() %>
<%=calc.getNum2() %> = <%=calc.caculate() %>
</h3>

</body>
</html>