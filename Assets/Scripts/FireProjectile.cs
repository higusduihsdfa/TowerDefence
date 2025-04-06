using UnityEngine;

//���� ����. 1.  ���־� ��Ʃ��� �� �ִ� git  ���캸��.
// 2. �浹�������� ������ �÷���.   --Ŀ���� ���    �����̳ʰ� �׽�Ʈ�� �� �ֵ��� �ϱ����� 
// 3. �浹�������� ������ �÷���.   --��Ŀ���� ���  ��ȣ�ϰ� ������. �����̳ʴ� �̰� ������Ѵ�. 
// 4. ���� �ٹ̱� ( Ÿ���� ��ġ�� ���� �ٹ̱�)   ����  

public class FireProjectile : MonoBehaviour
{    
    public GameObject projectile;          // The projectile prefab    
    public Transform  firePoint;           // The point from which the projectile will be fired
    public float launchVelocity = 700f;     

    public Rigidbody fireRigidbody;
    void Update()
    {       
        if(Input.GetKeyDown(KeyCode.F))           
        {          
            Fire();
        }
    }
    //�ٸ� ��ĵ� �׽�Ʈ �� ���ô�.  �����ϱ�  transform
    void Fire()
    {
        Rigidbody p = Instantiate(fireRigidbody, firePoint.position, firePoint.rotation);    
        p.velocity = firePoint.forward * launchVelocity;
    }
    
}
