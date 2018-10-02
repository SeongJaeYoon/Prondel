
public class Enemy_info{

    private int HP;

    public Enemy_info(int HP_){
        HP = HP_;
    }

    public void DecreaseHP(int damage){
        HP -= damage;            
    }

    public int ReturnHP() {
        return HP;
    }
	

}
