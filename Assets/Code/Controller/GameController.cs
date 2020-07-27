using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Model;
using System;

namespace Controller
{
    public class GameController : MonoBehaviour, IPointerClickHandler
    {
        public GameObject bishopWhite;
        public GameObject kingWhite;
        public GameObject knightWhite;
        public GameObject pawnWhite;
        public GameObject queenWhite;
        public GameObject rookWhite;

        public GameObject bishopBlack;
        public GameObject kingBlack;
        public GameObject knightBlack;
        public GameObject pawnBlack;
        public GameObject queenBlack;
        public GameObject rookBlack;

        public GameObject buttonStart;
        public GameObject buttonGoOn;
        public GameObject buttonExit;

        public GameObject go;

        private bool flag = false;

        void Start()
        {
            Debug.Log("Start");
            repoWhiteFigure = factoryInit(new FactoryWhite());
            repoBlackFigure = factoryInit(new FactoryBlack());
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {                
                go.transform.localRotation *= Quaternion.Euler(129, 180, 0);
                go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y, -go.transform.position.z - 14);
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                flag = !flag;
            }
            if (flag == true)
            {
                buttonStart.SetActive(flag);
                buttonGoOn.SetActive(flag);
                buttonExit.SetActive(flag);
            }
            else
            {
                buttonStart.SetActive(flag);
                buttonGoOn.SetActive(flag);
                buttonExit.SetActive(flag);
            }

        }

        public void GoOnGame()
        {
            flag = false;
            buttonStart.SetActive(flag);
            buttonGoOn.SetActive(flag);
            buttonExit.SetActive(flag);
        }

        public void StartNewGame()
        {
            Application.LoadLevel(1);
        }
        public void ExitGame()
        {
            Application.Quit();
        }

        protected RepoFigure repoWhiteFigure = new RepoWhiteFigure();
        protected RepoFigure repoBlackFigure = new RepoBlackFigure();

        protected void killFigure(Figure figure)
        {

        }

        protected void moveFigure(Figure figure, Coordinate coordinateToMove)
        {

        }

        protected void addFigure(Figure figure, Coordinate coordinateToAdd)
        {

        }

        protected RepoFigure factoryInit(FactoryAbstract factoryAbstract)
        {
            if (factoryAbstract.GetType().ToString().Equals("Model.FactoryWhite"))
                return factoryAbstract.createFigures(new List<GameObject> { pawnWhite, pawnWhite, pawnWhite, pawnWhite, pawnWhite, pawnWhite, pawnWhite, pawnWhite, rookWhite, rookWhite, knightWhite, knightWhite, bishopWhite, bishopWhite, kingWhite, queenWhite });
            else
                return factoryAbstract.createFigures(new List<GameObject> { pawnBlack, pawnBlack, pawnBlack, pawnBlack, pawnBlack, pawnBlack, pawnBlack, pawnBlack, rookBlack, rookBlack, knightBlack, knightBlack, bishopBlack, bishopBlack, kingBlack, queenBlack });
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            //Debug.Log("Mouse Click!");
        }

    }
}