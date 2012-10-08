<?php
require_once 'PPCertificateCredential.php';

/**
 * Test class for PPCertificateCredential.
 *
 */
class PPCertificateCredentialTest extends PHPUnit_Framework_TestCase
{
	/**
	 * @var PPCertificateCredential
	 */
	protected $object;

	/**
	 * Sets up the fixture, for example, opens a network connection.
	 * This method is called before a test is executed.
	 */
	protected function setUp()
	{
		$this->object = new PPCertificateCredential("platfo_1255077030_biz_api1.gmail.com", "1255077037", "cert_key.pem", "password", "APP-80W284485P519543T");
	}

	/**
	 * Tears down the fixture, for example, closes a network connection.
	 * This method is called after a test is executed.
	 */
	protected function tearDown()
	{
	}

	/**@test
	 */
	public function testValidateUname()
	{
		$this->setExpectedException('PPMissingCredentialException');
		$credUname = new PPCertificateCredential("", "1255077037", "cert_key.pem", "password", "APP-80W284485P519543T");
		$credUname->validate();
		
		$this->setNotExpectedException('PPMissingCredentialException');
		$credCorrect = new PPCertificateCredential("platfo_1255077030_biz_api1.gmail.com", "1255077037", "cert_key.pem", "password", "APP-80W284485P519543T");
		$var = $credCorrect->validate();
		$this->assertNull($var);
	}
	/**
	 * @test
	 */
	public function testValidatePwd()
	{
		$this->setExpectedException('PPMissingCredentialException');
		$credpwd = new PPCertificateCredential("platfo_1255077030_biz_api1.gmail.com", "", "cert_key.pem", "password", "APP-80W284485P519543T");
		$credpwd->validate();

	}
	/**
	 * @test
	 */
	public function testValidateCertPath()
	{
		$this->setExpectedException('PPMissingCredentialException');
		$credCertPath = new PPCertificateCredential("platfo_1255077030_biz_api1.gmail.com", "1255077037", "", "password", "APP-80W284485P519543T");
		$credCertPath->validate();
	}
	/**
	 * @test
	 */
	public function testValidateCertPassphrase()
	{
		$this->setExpectedException('PPMissingCredentialException');
		$credCertPath = new PPCertificateCredential("platfo_1255077030_biz_api1.gmail.com", "1255077037", "cert_key.pem", "", "APP-80W284485P519543T");
		$credCertPath->validate();
	}	
	/**
	 * @test
	 */
	public function testValidateAppId()
	{
		$this->setExpectedException('PPMissingCredentialException');
		$credAppid = new PPCertificateCredential("platfo_1255077030_biz_api1.gmail.com", "1255077037", "cert_key.pem", "password", "");
		$credAppid->validate();
	}

	/**
	 * @test
	 */
	public function testGetUserName()
	{
		$this->assertEquals('platfo_1255077030_biz_api1.gmail.com', $this->object->getUserName());

	}

	/**
	 * @test
	 */
	public function testGetPassword()
	{
		$this->assertEquals('1255077037', $this->object->getPassword());
	}

	/**
	 * @test
	 */
	public function testGetCertificatePath()
	{
		$this->assertStringEndsWith('cert_key.pem', $this->object->getCertificatePath());
	}

	/**@test
	 */
	public function testGetApplicationId()
	{
		$this->assertEquals('APP-80W284485P519543T', $this->object->getApplicationId());
	}
}
?>
