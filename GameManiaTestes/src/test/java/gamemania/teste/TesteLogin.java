package gamemania.teste;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

public class TesteLogin {
	
	private WebDriver driver;
	
	@Before
	public void ConfigurarTeste() {
		System.setProperty("webdriver.chrome.driver", "C:\\Program Files\\Chromedriver\\chromedriver.exe");
		driver = new ChromeDriver();
		driver.manage().window().maximize();
		
		driver.get("http://localhost:4200/");
		
		driver.findElement(By.xpath("//*[@id=\"menu\"]/a[2]")).click();
		
	}
	
	@Test
	public void TestarLogin() {
		
		WebElement campoEmail = driver.findElement(By.id("email"));
		WebElement campoSenha = driver.findElement(By.id("password"));
		WebElement botao = driver.findElement(By.id("botao-enviar"));
		
//      EXEMPLO 1
		try {
			String[] listaEmails = {"adrrrrr@email.com","adr@email.com","mara@email.com","adr@email.com"};
			String[] listaSenhas = {"senhaadr","senhaadrrrrrr","senhamara","senhaadr"};
			
			for(int contador = 0; contador <= 3; contador++ ) {
				campoEmail.sendKeys(listaEmails[contador]);
				campoSenha.sendKeys(listaSenhas[contador]);
				botao.click();
				
				Thread.sleep(3000);
				
				campoEmail.clear();
				campoSenha.clear();
			}
			
		}
		
     
/*		EXEMPLO 2
		try {
			
		// Caso de teste 1 – Email incorreto para o usuário cadastrado.
			
			campoEmail.sendKeys("adrrrrr@email.com");
			campoSenha.sendKeys("senhaadr");
			botao.click();
		
			Thread.sleep(3000);
		
			campoEmail.clear();
			campoSenha.clear();
		
		// Caso de teste 2 – Senha incorreta para o usuário cadastrado.
			
			campoEmail.sendKeys("adr@email.com");
			campoSenha.sendKeys("senhaadrrrrrr");
			botao.click();
		
			Thread.sleep(3000);
		
			campoEmail.clear();
			campoSenha.clear();
		
		// Caso de teste 3 – Usuário incorreto, não cadastrado.
			
			campoEmail.sendKeys("mara@email.com");
			campoSenha.sendKeys("senhamara");
			botao.click();
		
			Thread.sleep(3000);
		
			campoEmail.clear();
			campoSenha.clear();
		
		// Caso de teste 4 - Usuário correto, cadastrado.
			
			campoEmail.sendKeys("adr@email.com");
			campoSenha.sendKeys("senhaadr");
			botao.click();
		
			Thread.sleep(5000);
		
			campoEmail.clear();
			campoSenha.clear();
		} 
*/
		
		catch (InterruptedException e){
			e.printStackTrace();
		}
	}
		
	
	@After
	public void ConcluirTeste() {
		driver.quit();
	}
	

}
