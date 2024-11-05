<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<!-- table은 행(tr)과 열(td)로 구성 -->
<!-- 모든 행은 반드시 동일 한 개수의 열로 구성 -->
<table width="400" border="1" cellpadding="0" cellspacing="0">
	<tr>
		<td colspan="2">
			<jsp:include page="top.jsp" />
		</td>
	</tr>
	<tr>
		<td width="100" valign="top"> 
			<jsp:include page="left.jsp"></jsp:include>
		</td>
		<td width="300" valign="top">
			레이아웃1
			<jsp:include page="info.jsp"></jsp:include>
		</td>
	</tr>
	<tr>
		<td colspan="2">
			<jsp:include page="bottom.jsp" />
		</td>
	</tr>
</table>

</body>
</html>