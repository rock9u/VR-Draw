using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Answer answerData = new Answer;
		AnswerResult answerResult = new AnswerResult(answerData);		
	}
	
	// Update is called once per frame
	void Update () {
		answerData.setAnswer(true)

		if(answerResult.result){
			//you win, congratz
			//update scroe

		}else
		{
			//oh no you lost!
		
		}

		//lets try again
	}
}
public class Answer : Subject{
	private bool answer;
	private observers = new ArrayList();
	public Answer(){
		this.answer = false;
	}
	
	public void registerObserver(Observer o){
		observers.Add(o);
	}
	public void removeObserver(Observer o){
		//delete 
	}
	public void notify(){
		for(int i = 0; i <= observers.Count;i++){
			observers[i].update(false);
		}
	}

	public void setAnswer(bool b){
		this.answer = b;
		notify();
	}	
}

public void AnswerResult : Observer{
	private bool result;
	private Subject answerData; 
	public AnswerResult(Subject answerData){
		this.answerData = answerData;
		answerData.registerObserver(this);
			
	}

	public void update(bool b){
		this.result = b;

	}

}

public interface Subject{
	void registerObserver(Observer o);
	void removeObserver(Observer o);
	void notify();
}

public interface Observer{
	void update(bool b);
}


