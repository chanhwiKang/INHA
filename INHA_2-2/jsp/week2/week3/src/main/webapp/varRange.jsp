<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>

<h3>변수의 범위</h3>
<%! // 선언부
	
//	String strVar = "전역변수입니다.";
	String strVar; // 초기화 안하면 에러 없음 단, null
%>
<%!
	// 선언부 메소드 선언
	String getStr() {
		return strVar;
	}
%>
<%!
	// 선언부 메소드 선언
	/* String getStr2() {
		return strVar2; // 지역 변수이기 때문에 자기 영역 안애서만 호출가능
	} */
%>
<%	// 스크립틀릿

//	String strVar2 = "지역변수입니다.";
	String strVar2; // 초기화 안하면 에러 발생
%>
<br>
선언문에서 선언한 변수 strVar = <%= getStr() %><br>
스크립틀릿에서 선언한 변수 strVar2 = <%= strVar2 %>
</body>
</html>