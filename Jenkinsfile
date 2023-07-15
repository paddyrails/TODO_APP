pipeline {
  agent any

  stages {
    stage("Clean Up"){
      steps {
        deleteDir()
        echo "${BRANCH_NAME} ${CHANGE_ID}"
      }
    }
     stage("Clone Repo"){
      steps {
        sh "git clone https://github.com/paddyrails/TODO_APP.git"
      }
    }
    stage("Build"){
      steps {
        dir("TODO_APP"){
          echo "Running build.."    
          echo "running tests.."
        }
      }
    }
  }
}
