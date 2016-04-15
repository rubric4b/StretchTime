################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
../inc/stretching/glm/detail/glm.cpp 

OBJS += \
./inc/stretching/glm/detail/glm.o 

CPP_DEPS += \
./inc/stretching/glm/detail/glm.d 


# Each subdirectory must supply rules for building sources it contributes
inc/stretching/glm/detail/%.o: ../inc/stretching/glm/detail/%.cpp
	@echo 'Building file: $<'
	@echo 'Invoking: C++ Compiler'
	$(CXX) -I"pch" -D_DEBUG -I"$(PROJ_PATH)\inc" -I@system_includes -I"$(PROJ_PATH)\inc\stretching" -O0 -g3 -Wall -c -fmessage-length=0 $(TC_COMPILER_MISC) -fPIE --sysroot="$(SBI_SYSROOT)" -I@system_includes -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


