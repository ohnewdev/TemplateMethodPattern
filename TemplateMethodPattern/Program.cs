using System;

/// <summary>
/// 템플릿 패턴
/// : 공통적인 프로세스를 묶어 주기
/// : 알고리즘의 구조를 메소드에 정의 하고 
///    하위 클래스에서 알고리즘 구조의 
///    변경없이 알고리즘을 재정의 하는 패턴
///    
/// 
///  언제사용?
/// : 구현하려는 알고리즘이 일정한 프로세스가 있다.
/// : 구현하려는 알고리즘이 변경가능성이 있다.
/// 
/// 
/// 구현방법?
/// : 알고리즘을 여러단계로 나눈다.
/// : 나눠진 알고리즘의 단계를 메소드로 선언한다.
/// : 알고리즘을 수행할 템플릿 메소드를 만든다.
/// : 하위 클래스에서 나눠진 메소들을 구현한다.
/// 
/// 요구사항
/// 1. 신작 게임의 접속을 구현해주세요
///     requestConnection(String str):String
/// 2. 유저가 게임 접속시 다음을 고려해야 합니다.
///     1) 보안과정 : 보안 관련부분을 처리합니다.
///         doSecurity(String string):String
///     2) 인증과정 : user name 과 password 가 일치하는지 확인합니다.
///         authentication(String id, String password):bool
///     3) 권한과정 : 접속자가 유료 회원인지 무료회원인지 게임 마스터인지 확인
///        authorization(string userName):int
///     4) 접속과정 : 접속자에게 커넥션을 정보를 넘겨줍니다.
///        connection(string info):string
///        
/// 
/// 
/// ref : https://www.youtube.com/watch?v=qr7I18Lhsl8&list=PLsoscMhnRc7pPsRHmgN4M8tqUdWZzkpxY&index=2
/// 
/// </summary>
namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public abstract class AbstGameConnectHelper
    {
        protected abstract string DoSecurity(string str);
        protected abstract bool Authentication(string id, string password);
        protected abstract int Authorization(string userName);
        protected abstract string Connection(string info);

        // 템플릿 메소드 
        public string requestConnection(string str)
        {
            return null;
        }

    }
}
