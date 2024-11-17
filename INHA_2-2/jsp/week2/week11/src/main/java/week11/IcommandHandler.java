package week11;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public interface IcommandHandler {
	public String process(HttpServletRequest reqest, 
							HttpServletResponse response);
}
